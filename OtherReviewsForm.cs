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
            Dictionary<string, object> reviewDict = new Dictionary<string, object>();
            //Proveriti da li je pametno pretrazivati po tekstu recenzije ili dodati ID!
            reviewDict.Add("Review", Reviews.SelectedItem.ToString());
            reviewDict.Add("BookTitle", findOtherReviewComboBox.SelectedItem.ToString());

            var query = new Neo4jClient.Cypher.CypherQuery("match (a)-[r:COMMENTED]->(u) where u.Text =~ {Review} return r.Comment",
                                                         reviewDict, CypherResultMode.Set);
            List<String> uploadedReviews = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList();

            for (int i = 0; i < uploadedReviews.Count; i++)
            {
                Comments.Items.Add(uploadedReviews.ElementAt(i));
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

            List<UserReview> quotes3 = ((IRawGraphClient)client).ExecuteGetCypherResults<UserReview>(query3).ToList();
            Comments.Items.Add(commentTextBox.Text);
        }
    }
}
