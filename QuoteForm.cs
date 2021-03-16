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
    public partial class QuoteForm : Form
    {
        public GraphClient client;
        public QuoteForm()
        {
            InitializeComponent();
        }

        private void myQuoteButton_Click(object sender, EventArgs e)
        {
            String activeUser = Global.ActiveUser.Username;

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("ActiveUser", activeUser);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u)-[r1:ADDED]->(q)-[r:TAKENFROM]->(b) where u.Username =~ {ActiveUser} return r1{Quote:q, Book:b}",
                                                         myQuotesDict, CypherResultMode.Set);
            List<QuoteBook> uploadedQuotes = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteBook>(query).ToList();

            for (int i = 0; i < uploadedQuotes.Count; i++)
            {
                Books.Items.Add(uploadedQuotes.ElementAt(i).Book.Name);
                Quotes.Items.Add(uploadedQuotes.ElementAt(i).Quote.Text);
            }
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuoteForm addQuoteForm = new AddQuoteForm();
            addQuoteForm.client = client;
            addQuoteForm.ShowDialog();
        }

        private void deleteQuoteBtn_Click(object sender, EventArgs e)
        {
            if (Quotes.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a quote you want to delete!");
                return;
            }
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("Text", Quotes.SelectedItem.ToString());
            int itemIndex = Quotes.SelectedIndex;

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Quote) and exists(n.Text) and n.Text =~ {Text} detach delete n",
                                                            queryDict, CypherResultMode.Projection);

            List<Review> quotes = ((IRawGraphClient)client).ExecuteGetCypherResults<Review>(query).ToList();

            MessageBox.Show("Review successfully deleted!");
            Quotes.Items.RemoveAt(itemIndex);
            Books.Items.RemoveAt(itemIndex);
        }

        private void findQuotesBtn_Click(object sender, EventArgs e)
        {
            FindQuoteForm findQuoteForm = new FindQuoteForm();
            findQuoteForm.client = client;
            findQuoteForm.ShowDialog();
        }
    }
}
