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
            queryQuoteBookDict.Add("Book", quote.Item2.Book);
            queryQuoteBookDict.Add("Quote", quote.Item2.Quote);

            String BookName =  quote.Item2.Book.Name;
            String Text = quote.Item2.Quote.Text;

            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (a:Quote),(b:Book)" +
                                                            "WHERE a.Text =~ '" + Text + "' AND b.Name =~ '" + BookName + "' CREATE(a) -[r:TAKENFROM]->(b)" +
                                                             "RETURN type(r)",
                                                            queryQuoteBookDict, CypherResultMode.Set);

            List <QuoteBook> quotes2 = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteBook>(query2).ToList();

            Dictionary<string, object> queryQuoteUserDict = new Dictionary<string, object>();
            queryQuoteUserDict.Add("User", quote.Item3.User);
            queryQuoteUserDict.Add("Quote", quote.Item3.Quote);
            queryQuoteUserDict.Add("UploadedDate", quote.Item3.UploadDate);

            String UserName = quote.Item3.User.Name;

            var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH" +
                                                            "(a: User)," +
                                                            "(b: Quote)" +
                                                            "WHERE a.Username =~ '"+ UserName+ "' AND b.text =~ '" + Text+"'" +
                                                            "CREATE(a) -[r: ADDED]->(b)" +
                                                            "RETURN type(r)",
                                                            queryQuoteUserDict, CypherResultMode.Set);

            List<QuoteUser> quotes3 = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteUser>(query3).ToList();


            Dictionary<string, object> queryQuoteWriterDict = new Dictionary<string, object>();
            queryQuoteWriterDict.Add("Quote", quote.Item4.Quote);
            queryQuoteWriterDict.Add("Writer", quote.Item4.Writer);

            String WriterName = quote.Item4.Writer.Name;

            var query4 = new Neo4jClient.Cypher.CypherQuery("MATCH (a:Quote), (b:Writer)" +
                                                            "WHERE a.Text =~ '" + Text + "' AND b.Name =~ '" + WriterName + "' CREATE(a) -[r:ISWRITTENBY]->(b)" +
                                                             "RETURN type(r)",
                                                            queryQuoteWriterDict, CypherResultMode.Set);

            List<QuoteWriter> quotes4 = ((IRawGraphClient)client).ExecuteGetCypherResults<QuoteWriter>(query4).ToList();

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
