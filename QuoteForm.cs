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
            String UploadedBy = Global.ActiveUser.Username;

            Dictionary<string, object> myBooksDict = new Dictionary<string, object>();
            myBooksDict.Add("UploadedBy", UploadedBy);
           
            var query = new Neo4jClient.Cypher.CypherQuery("match (q)-[r:ADDED_BY]->(u) where u.Username = '"+UploadedBy+"' return r{Quote:q}",
                                                         myBooksDict, CypherResultMode.Set);
            List<QuoteBook> uploadedQuotes = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteBook>(query).ToList();

            for (int i = 0; i< uploadedQuotes.Count; i++)
            {
                Quotes.Items.Add(uploadedQuotes.ElementAt(i).Quote.Text);
                Books.Items.Add(uploadedQuotes.ElementAt(i).Book.Name);
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
