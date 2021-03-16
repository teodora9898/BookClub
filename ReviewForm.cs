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
    public partial class ReviewForm : Form
    {
        public GraphClient client;
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void addReviewButton_Click(object sender, EventArgs e)
        {
            bookComboBox addReviewForm = new bookComboBox();
            addReviewForm.client = client;
            addReviewForm.ShowDialog();
        }

        private void myReviewsButton_Click(object sender, EventArgs e)
        {
            num.Items.Clear();
            String activeUser = Global.ActiveUser.Username;

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("ActiveUser", activeUser);

            var query = new Neo4jClient.Cypher.CypherQuery("match (b)-[r1:UPPLOADED]->(a)-[r:IS_FROM]->(u) where b.Username =~ {ActiveUser} return r{Review:a, Book:u}",
                                                         myQuotesDict, CypherResultMode.Set);
            List<BookReview> uploadedQuotes = ((IRawGraphClient)client).ExecuteGetCypherResults<BookReview>(query).ToList();

            for (int i = 0; i < uploadedQuotes.Count; i++)
            {
                if (!(Reviews.Items.Contains(uploadedQuotes.ElementAt(i).Review.Text) && Books.Items.Contains(uploadedQuotes.ElementAt(i).Book.Name)))
                {
                    Reviews.Items.Add(uploadedQuotes.ElementAt(i).Review.Text);
                    Books.Items.Add(uploadedQuotes.ElementAt(i).Book.Name);
                }
            }
        }

        private void findReviewsBtn_Click(object sender, EventArgs e)
        {
            OtherReviewsForm otherReviewsForm = new OtherReviewsForm();
            otherReviewsForm.client = client;
            otherReviewsForm.ShowDialog();
        }

        private void deleteReviewBtn_Click(object sender, EventArgs e)
        {
            if (Reviews.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a review you want to delete!");
                return;
            }
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("Text", Reviews.SelectedItem.ToString());
            int itemIndex = Reviews.SelectedIndex;

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Review) and exists(n.Text) and n.Text =~ {Text} detach delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Review> quotes = ((IRawGraphClient)client).ExecuteGetCypherResults<Review>(query).ToList();

            MessageBox.Show("Review successfully deleted!");
            Reviews.Items.RemoveAt(itemIndex);
            Books.Items.RemoveAt(itemIndex);
        }

        private void updateReviewBtn_Click(object sender, EventArgs e)
        {
            if (Reviews.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a review you want to update!");
                return;
            }
            int itemIndex = Reviews.SelectedIndex;
            String ReviewText = Reviews.SelectedItem.ToString();
            String Update = updateTextBox.Text;
            
            var query = new Neo4jClient.Cypher.CypherQuery("Match(n) where (n:Review) and n.Text = '"+ ReviewText +"'  set n.Text = '"+ Update +"' return n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Review> reviews = ((IRawGraphClient)client).ExecuteGetCypherResults<Review>(query).ToList();

            MessageBox.Show("Review successfully updated!");
            Reviews.Items.RemoveAt(itemIndex);
            Reviews.Items.Insert(itemIndex, Update);
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {

        }

        private void Reviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Reviews.SelectedIndex != -1)
            {
                num.Items.Clear();
                whoLikedListBox.Items.Clear();
                String activeUser = Global.ActiveUser.Username;
                String review = Reviews.SelectedItem.ToString();
            
                Dictionary<string, object> myReviewDict = new Dictionary<string, object>();
                myReviewDict.Add("ActiveUser", activeUser);
                myReviewDict.Add("Review", review);

                var query2 = new Neo4jClient.Cypher.CypherQuery("match (u)-[r:LIKED]->(a) where u.Username = '" + activeUser + "' and a.Text = '" + review + "' return r{User:u,Review:a}",
                                                             myReviewDict, CypherResultMode.Set);
                List<UserReviewLikes> likes = ((IRawGraphClient)client).ExecuteGetCypherResults<UserReviewLikes>(query2).ToList();

                num.Items.Add(likes.Count.ToString());
                for (int i = 0; i < likes.Count; i++)
                {
                    whoLikedListBox.Items.Add(likes.ElementAt(i).User.Username);
                }
            }
        }
    }
}
