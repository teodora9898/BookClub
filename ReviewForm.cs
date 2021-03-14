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
            String activeUser = Global.ActiveUser.Username;

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("ActiveUser", activeUser);

            var query = new Neo4jClient.Cypher.CypherQuery("match (b)-[r1:UPPLOADED]->(a)-[r:IS_FROM]->(u) where u.Username =~ {ActiveUser} return r1{Review:a, Book:u}",
                                                         myQuotesDict, CypherResultMode.Set);
            List<BookReview> uploadedQuotes = ((IRawGraphClient)client).ExecuteGetCypherResults<BookReview>(query).ToList();

            for (int i = 0; i < uploadedQuotes.Count; i++)
            {
                Reviews.Items.Add(uploadedQuotes.ElementAt(i).Review.Text);
                Books.Items.Add(uploadedQuotes.ElementAt(i).Book.Name);
            }
        }

        private void findReviewsBtn_Click(object sender, EventArgs e)
        {
            OtherReviewsForm otherReviewsForm = new OtherReviewsForm();
            otherReviewsForm.client = client;
            otherReviewsForm.ShowDialog();
        }
    }
}
