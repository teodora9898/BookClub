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

    }
}
