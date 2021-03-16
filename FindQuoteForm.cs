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
    public partial class FindQuoteForm : Form
    {
        public GraphClient client;
        public FindQuoteForm()
        {
            InitializeComponent();
        }

        private void myBookmarksBtn_Click(object sender, System.EventArgs e)
        {
            Books.Items.Clear();
            Quotes.Items.Clear();

            String activeUser = Global.ActiveUser.Username.ToString();

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("ActiveUser", activeUser);

            var query = new Neo4jClient.Cypher.CypherQuery("match (u)-[r1:IS_BOOKMARKED]->(q)-[r:TAKENFROM]->(b) where u.Username = {ActiveUser} return r{Book:b, Quote:q}",
                                                         myQuotesDict, CypherResultMode.Set);
            List<QuoteBook> bookmarkedQuotes = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteBook>(query).ToList();

            for (int i = 0; i < bookmarkedQuotes.Count; i++)
            {
                if (!Quotes.Items.Contains(bookmarkedQuotes.ElementAt(i).Quote.Text))
                {
                    Quotes.Items.Add(bookmarkedQuotes.ElementAt(i).Quote.Text);
                    Books.Items.Add(bookmarkedQuotes.ElementAt(i).Book.Name);
                }
            }
        }

        private void bookmarkBtn_Click(object sender, System.EventArgs e)
        {
            if (Quotes.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a quote you want to bookmaerk!");
                return;
            }
            String quoteText = Quotes.SelectedItem.ToString();
            String activeUser = Global.ActiveUser.Username.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("QuoteText", quoteText);
            queryDict.Add("ActiveUser", activeUser);

            var queryIf = new Neo4jClient.Cypher.CypherQuery("MATCH (q:Quote{Text:{QuoteText}})<-[r:IS_BOOKMARKED]-(u:User{Username:{ActiveUser}}) " +
                                                                                 "RETURN r{Quote:q, User:u}",
                                                         queryDict, CypherResultMode.Set);
            List<QuoteUserBookmark> quoteIf = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteUserBookmark>(queryIf).ToList();
            if (quoteIf.Count != 0)
            {
                int quoteIndex = Quotes.SelectedIndex;
                String username = Global.ActiveUser.Username;
                String quote = Quotes.SelectedItem.ToString();

                Dictionary<string, object> queryDict2 = new Dictionary<string, object>();

                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (User {Username: '" + username + "'})-[r:IS_BOOKMARKED]->(Quote {Text:'" + quote + "'})" +
                                                               "DELETE r",
                                                                queryDict2, CypherResultMode.Projection);

                List<QuoteUserBookmark> actors = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteUserBookmark>(query).ToList();
                Quotes.Items.RemoveAt(quoteIndex);
                Books.Items.RemoveAt(quoteIndex);
            }
            else
            {
                var queryBookmark = new Neo4jClient.Cypher.CypherQuery("MATCH (q:Quote), (u:User) WHERE q.Text = {QuoteText} " +
                                                                         "AND u.Username = {ActiveUser}" +
                                                                         "CREATE (u)-[r:IS_BOOKMARKED]->(q)" +
                                                                         "RETURN r{Quote:q, User:u}",
                                                 queryDict, CypherResultMode.Set);
                List<QuoteUserBookmark> quote = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteUserBookmark>(queryBookmark).ToList();
            }
        }

        private void searchByWriterBtn_Click(object sender, EventArgs e)
        {
            Books.Items.Clear();
            string[] subs = quoteTextBox.Text.Split(' ');
            string writersNameSubstring1 = ".*" + "(?i)" + subs[0] + ".*";
            string writersNameSubstring2 = null;
            if (subs.Count() == 2)
            {
                writersNameSubstring2 = ".*" + "(?i)" + quoteTextBox.Text.Split(new[] { ' ' }, 2)[1] + ".*";
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("writerName", writersNameSubstring1);
            queryDict.Add("writerLastname", writersNameSubstring2);

            var query = new Neo4jClient.Cypher.CypherQuery("match (w:Writer)-[r:WROTE]->(b:Book)<-[r1:TAKENFROM]-(q:Quote) where" +
                                                           "(w.Name =~'Mihail' or w.Lastname =~'Mihail') or" +
                                                           "(w.Name =~'Mihail' and w.Lastname =~'Mihail') return r1{ Quote: q, Book: b}",
                                                            queryDict, CypherResultMode.Set);

            List<QuoteBook> quotes = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteBook>(query).ToList();

            foreach (QuoteBook q in quotes)
            {
                Quotes.Items.Add(q.Quote.Text);
                Books.Items.Add(q.Book.Name);
            }
        }

        private void searchByNameBtn_Click(object sender, EventArgs e)
        {
            Quotes.Items.Clear();
            Books.Items.Clear();
            string quoteText = ".*" + "(?i)" + quoteTextBox.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("quoteText", quoteText);

            var query = new Neo4jClient.Cypher.CypherQuery("start q=node(*) where (q:Quote) and exists(q.Text) and q.Text =~ {quoteText} return q",
                                                            queryDict, CypherResultMode.Set);

            List<Quote> quotes = ((IRawGraphClient)client).ExecuteGetCypherResults<Quote>(query).ToList();

            foreach (Quote q in quotes)
            {
                Quotes.Items.Add(q.Text);
            }
        }
    }
}
