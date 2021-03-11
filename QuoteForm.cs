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
            String UploadedBy = ".*" + Global.ActiveUser.Username + ".*";

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("UploadedBy", UploadedBy);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (q)-[r:UPLOADED_BY]->(u) where u.Username =~ {UploadedBy} return r",
                                                         myQuotesDict, CypherResultMode.Set);

            List<Quote> uploadedQuotes = ((IRawGraphClient)client).ExecuteGetCypherResults<Quote>(query).ToList();


            Dictionary<string, object> quoteBookDict = new Dictionary<string, object>();
            List<QuoteBook> books;
            foreach (var quote in uploadedQuotes)
            {
                String BookName = ".*" +
                Quotes.Items.Add(quote.Text);
                quoteBookDict.Add("Text", quote.Text);
                var queryBooks = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (q)-[r:ISEXTRACTEDFROM]->(b) where b.Name =~ {BookName} return r{Quote:q}",
                     quoteBookDict, CypherResultMode.Set);
                books = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteBook>(queryBooks).ToList();
                Books.Items.Add(books.ElementAt(0).Book.Name);
                myQuotesDict.Remove("BookName");

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
