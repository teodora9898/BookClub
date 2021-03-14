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
    public partial class AddQuoteForm : Form
    {
        public GraphClient client;
        public AddQuoteForm()
        {
            InitializeComponent();
        }

        private void quoteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private Tuple<Quote, QuoteBook, QuoteUser, QuoteWriter> createQuote()
        {
            Quote quote = new Quote()
            {
                Text = quoteTextBox.Text,
                UploadedBy = Global.ActiveUser.Name + Global.ActiveUser.Lastname
            };
            QuoteBook qb = new QuoteBook();
            qb.Quote = quote;

                var bookTitle = quoteComboBox.Text;
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("Name", bookTitle);
                
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH(n: Book) WHERE n.Name = '" + bookTitle + "' RETURN n",
                                                                queryDict, CypherResultMode.Set);
                Book book1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).FirstOrDefault();
                qb.Book = book1;
            QuoteWriter quoteWriter = new QuoteWriter();

            quoteWriter.Quote = quote;
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (Book {Name: '" + bookTitle + "'})--(writer) RETURN writer",
                                                                queryDict, CypherResultMode.Set);
            Writer w = ((IRawGraphClient)client).ExecuteGetCypherResults<Writer>(query2).FirstOrDefault();
            quoteWriter.Writer = w;

            QuoteUser qu = new QuoteUser()
            {
                Quote = quote,
                User = Global.ActiveUser,
                UploadDate = DateTime.Now
            };

            return new Tuple<Quote, QuoteBook, QuoteUser, QuoteWriter>(quote, qb, qu, quoteWriter);
        }

        private void showAllBooksBtn_Click(object sender, EventArgs e)
        {
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Book)" +
                                                               "RETURN n",
                                                             new Dictionary<string, object>(), CypherResultMode.Set);
                List<Book> uploadedBooks = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();


                foreach (Book b in uploadedBooks)
                {
                    quoteComboBox.Items.Add(b.Name);
                }
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            Tuple<Quote, QuoteBook, QuoteUser, QuoteWriter> quote = this.createQuote();

            Dictionary<string, object> queryBookDict = new Dictionary<string, object>();
            queryBookDict.Add("Text", quote.Item1.Text);
            queryBookDict.Add("UploadedBy", quote.Item1.UploadedBy);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Quote {Text:'" + quote.Item1.Text + "', UploadedBy:'" + quote.Item1.UploadedBy
                                                            + "'}) return n",
                                                            queryBookDict, CypherResultMode.Set);

            List<Quote> quotes = ((IRawGraphClient)client).ExecuteGetCypherResults<Quote>(query).ToList();

            foreach (Quote q in quotes)
            {
                MessageBox.Show("Uspesno dodat citat.");
            }


            Dictionary<string, object> queryQuoteBookDict = new Dictionary<string, object>();
            queryQuoteBookDict.Add("Text", quote.Item2.Quote.Text);
            queryQuoteBookDict.Add("BookName", quote.Item2.Book.Name);



            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (a:Quote),(b:Book)" +
                                                            "WHERE a.Text =~ {Text} AND b.Name =~ {BookName} CREATE(a) -[r:TAKENFROM]->(b)" +
                                                             "RETURN r{Quote:a, Book:b}",
                                                            queryQuoteBookDict, CypherResultMode.Set);

            List<QuoteBook> quotes2 = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteBook>(query2).ToList();

            Dictionary<string, object> queryQuoteUserDict = new Dictionary<string, object>();

            queryQuoteUserDict.Add("Username", quote.Item3.User.Username);
            queryQuoteUserDict.Add("Text", quote.Item3.Quote.Text);


            var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH" +
                                                            "(a:User)," +
                                                            "(b:Quote)" +
                                                            "WHERE a.Username =~ {Username} AND b.Text =~ {Text}" +
                                                            "CREATE (a) -[r:ADDED]->(b)" +
                                                            "RETURN r{User:a, Quote:b}",
                                                            queryQuoteUserDict, CypherResultMode.Set);


            List<QuoteUser> quotes3 = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteUser>(query3).ToList();


            Dictionary<string, object> queryQuoteWriterDict = new Dictionary<string, object>();
            queryQuoteWriterDict.Add("Text", quote.Item4.Quote.Text);
            queryQuoteWriterDict.Add("WriterName", quote.Item4.Writer.Name);

            var query4 = new Neo4jClient.Cypher.CypherQuery("MATCH" +
                                                            "(a:Quote)," +
                                                            "(b:Writer)" +
                                                            "WHERE a.Text =~ {Text} AND b.Name =~ {WriterName}" +
                                                            "CREATE (a) -[r:IS_WRITTEN_BY]->(b)" +
                                                            "RETURN r{Quote:a, Writer:b}",
                                                            queryQuoteWriterDict, CypherResultMode.Set);

            List<QuoteWriter> quotes4 = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteWriter>(query4).ToList();
            //Vidi zasto ovaj zadnji deo nece!!
            this.Close();
        }

        
        /*private void quoteComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(quoteComboBox.Text))
            {
                e.Cancel = true;
                quoteComboBox.Focus();
                errorProvider1.SetError(quoteComboBox, "Choose a book you want to add quote for!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(quoteComboBox, null);
            }
        }*/

    }
}
