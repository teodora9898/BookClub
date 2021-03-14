using BookClub.Domain_models;
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
            String bookTitle = findOtherReviewComboBox.SelectedItem.ToString();

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("BookTitle", bookTitle);

            var query = new Neo4jClient.Cypher.CypherQuery("match (a)-[r:IS_FROM]->(u) where u.Name =~ {BookTitle} return a",
                                                         myQuotesDict, CypherResultMode.Set);
            List<Review> uploadedReviews = ((IRawGraphClient)client).ExecuteGetCypherResults<Review>(query).ToList();

            for (int i = 0; i < uploadedReviews.Count; i++)
            {
                Reviews.Items.Add(uploadedReviews.ElementAt(i).Text);
            }
        }
    }
}
