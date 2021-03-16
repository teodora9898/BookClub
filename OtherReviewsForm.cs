using BookClub.Domain_models;
using BookClub.Help;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookClub
{
    public partial class OtherReviewsForm : Form
    {
        public GraphClient client;
        public OtherReviewsForm()
        {
            InitializeComponent();
        }

        private void OtherReviewsForm_Load(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (b:Book) return distinct b",
                                                         new Dictionary<string, object>(), CypherResultMode.Set);

            List<Book> books = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            foreach (Book b in books)
            {
                findOtherReviewComboBox.Items.Add(b.Name);
            }
            Dictionary<string, object> queryLikeDict = new Dictionary<string, object>();

            queryLikeDict.Add("Username", Global.ActiveUser.Username);
            var query3 = new Neo4jClient.Cypher.CypherQuery("match (u)-[r:LIKED]->(a) where u.Username =~ {Username} return a",
                                                           queryLikeDict, CypherResultMode.Set);

            List<Review> likedReviews = ((IRawGraphClient)client).ExecuteGetCypherResults<Review>(query3).ToList();
            for (int i = 0; i < likedReviews.Count; i++)
            {
                    Likes.Items.Add(likedReviews.ElementAt(i).Text);
            }
        }

        private void findReviewBtn_Click(object sender, EventArgs e)
        {
            if (findOtherReviewComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a book you want to find review for!");
                return;
            }

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("BookTitle", findOtherReviewComboBox.SelectedItem.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("match (a)-[r:IS_FROM]->(u) where u.Name =~ {BookTitle} return a",
                                                         myQuotesDict, CypherResultMode.Set);
            List<Review> uploadedReviews = ((IRawGraphClient)client).ExecuteGetCypherResults<Review>(query).ToList();

            for (int i = 0; i < uploadedReviews.Count; i++)
            {
                if (!Reviews.Items.Contains(uploadedReviews.ElementAt(i).Text))
                {
                    Reviews.Items.Add(uploadedReviews.ElementAt(i).Text);
                }
            }
        }

        private void Reviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comments.Items.Clear();
            Dictionary<string, object> reviewDict = new Dictionary<string, object>();
            //Proveriti da li je pametno pretrazivati po tekstu recenzije ili dodati ID!
            reviewDict.Add("Review", Reviews.SelectedItem.ToString());
            reviewDict.Add("BookTitle", findOtherReviewComboBox.SelectedItem.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("match (a)-[r:COMMENTED]->(u) where u.Text =~ {Review} return r.Comment",
                                                         reviewDict, CypherResultMode.Set);
            List<String> uploadedReviews = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList();

            //todo Andjelka Probaj da strpas sve u jedan query!!!!
            var query2 = new Neo4jClient.Cypher.CypherQuery("match (a)-[r:COMMENTED]->(u) where u.Text =~ {Review} return u",
                                                         reviewDict, CypherResultMode.Set);
            List<User> user = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query2).ToList();

            for (int i = 0; i < uploadedReviews.Count; i++)
            {
                Comments.Items.Add(uploadedReviews.ElementAt(i));
                //usernameTextBox.Items.Add(user.ElementAt(i).Username);
            }
        }

        private void addReviewCommentBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryCommentReviewDict = new Dictionary<string, object>();
            queryCommentReviewDict.Add("Comment", commentTextBox.Text);
            queryCommentReviewDict.Add("Text", Reviews.SelectedItem.ToString());
            queryCommentReviewDict.Add("Username", Global.ActiveUser.Username);

            var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (a:User),(b:Review)" +
                                                            "WHERE a.Username =~ {Username} AND b.Text =~ {Text} " +
                                                            "CREATE(a) -[r:COMMENTED {Comment:{Comment}}]->(b)" +
                                                             "RETURN r{User:a, Review:b}",
                                                           queryCommentReviewDict, CypherResultMode.Set);

            List<UserReviewLikes> quotes3 = ((IRawGraphClient)client).ExecuteGetCypherResults<UserReviewLikes>(query3).ToList();
            Comments.Items.Add(commentTextBox.Text);
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            String review = Reviews.SelectedItem.ToString();
            if (!Likes.Items.Contains(review))
            {
                Dictionary<string, object> queryLikeDict = new Dictionary<string, object>();
                queryLikeDict.Add("Username", Global.ActiveUser.Username);
                queryLikeDict.Add("Text", Reviews.SelectedItem.ToString());

                var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (a:User),(b:Review)" +
                                                                "WHERE a.Username =~ {Username} AND b.Text =~ {Text} " +
                                                                "CREATE(a) -[r:LIKED]->(b)" +
                                                                 "RETURN r{User:a, Review:b}",
                                                               queryLikeDict, CypherResultMode.Set);

                List<UserReviewLikes> quotes3 = ((IRawGraphClient)client).ExecuteGetCypherResults<UserReviewLikes>(query3).ToList();
                if (!Likes.Items.Contains(review))
                {
                    Likes.Items.Add(review);
                }
            }
        }
        
        private void dislikeBtn_Click(object sender, EventArgs e)
        {
            if (Likes.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a review you want to dislike!");
                return;
            }
            int reviewIndex = Likes.SelectedIndex;
            String username = Global.ActiveUser.Username;
            String review = Likes.SelectedItem.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            int itemIndex = Reviews.SelectedIndex;

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (User {Username: '"+ username +"'})-[r:LIKED]->(Review {Text:'"+ review +"'})" +
                                                           "DELETE r",
                                                            queryDict, CypherResultMode.Projection);

            List<UserReviewLikes> actors = ((IRawGraphClient)client).ExecuteGetCypherResults<UserReviewLikes>(query).ToList();
            Likes.Items.RemoveAt(reviewIndex);
        }
    }
}
