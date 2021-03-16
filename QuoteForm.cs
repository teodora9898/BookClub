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

        private void bookmarkBtn_Click(object sender, EventArgs e)
        {
            String quoteText = Quotes.SelectedItem.ToString();
            String activeUser = Global.ActiveUser.Username.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("QuoteText", quoteText);
            queryDict.Add("ActiveUser", activeUser);

            var queryIf = new Neo4jClient.Cypher.CypherQuery("MATCH (b:Quote{Text:{QuoteText}})<-[r:IS_BOOKMARKED]-(u:User{Username:{ActiveUser}}) " +
                                                                                 "RETURN r{Book:b, User:u}",
                                                         queryDict, CypherResultMode.Set);
            List<QuoteUserBookmark> quoteIf = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteUserBookmark>(queryIf).ToList();
            if (quoteIf.Count != 0)
            {
                MessageBox.Show("This quote is already bookmarked");
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

        private void myBookmarksBtn_Click(object sender, EventArgs e)
        {
            /*Books.Items.Clear();
            Quotes.Items.Clear();

            String activeUser = Global.ActiveUser.Username.ToString();

            Dictionary<string, object> myQuotesDict = new Dictionary<string, object>();
            myQuotesDict.Add("ActiveUser", activeUser);

            //todo : smisli query : preko grane ili preko propertija? Mozda je bolje opreko grane?
            var query = new Neo4jClient.Cypher.CypherQuery("match (u)-[r1:IS_BOOKMARKED]->(q)-[r:TAKENFROM]->(b) where u.Username = 'Ann' and q.Text = 'PRIKAZI SE' return r{Book:b, Quote:q}",
                                                         myQuotesDict, CypherResultMode.Set);
            List<QuoteUserBookmark> bookmarkedQuotes = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteUserBookmark>(query).ToList();

            for (int i = 0; i < bookmarkedQuotes.Count; i++)
            {
                if (!Books.Items.Contains(bookmarkedQuotes.ElementAt(i).Quote.Text))
                {
                    Quotes.Items.Add(bookmarkedQuotes.ElementAt(i).Quote.Text);
                    Books.Items.Add(bookmarkedQuotes.ElementAt(i). + " " + bookmarkedBooks.ElementAt(i).Writer.Lastname);
                }
            }*/
        }
    }
}
