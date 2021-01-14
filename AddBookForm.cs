using BookClub.Domain_models;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BookClub.Help;
using Neo4jClient.Cypher;
using System.Linq;

namespace BookClub
{
    public partial class AddBookForm : Form
    {
        public GraphClient client;
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void summaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Tuple<Book, Writer, BookWriter, BookUser > CreateBookAndWriter()
        {
            
            Book book = new Book()
            {
                Name = bookNameTextBox.Text,
                Genre = bookGenreTextBox.Text,
                Summary = summaryTextBox.Text,
                Publisher = publisherTextBox.Text,
                NumberOfPages = numberOfPagesnumericUpDown.Value.ToString(),
                YearOfPublish = yearOfPublishnumericUpDown.Value.ToString()
            };
            Writer writer = new Writer()
            {
                Name = writerNameTextBox.Text,
                Lastname = writerLastnameTextBox.Text,
                Biography = biographyTextBox.Text,
                Birthday = dateTimePicker1.Value.ToString()
            };
            BookWriter bookWriter = new BookWriter()
            {
                Book = book,
                Writer = writer,
                InterestingFacts = additionalInformationTextBox.Text
            };
            BookUser bookUser = new BookUser()
            {
                Book = book,
                User = Global.ActiveUser,
                UploadDate = DateTime.Today
            };
            

            return new Tuple<Book, Writer, BookWriter, BookUser>(book, writer, bookWriter, bookUser);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var bookAndWriter = CreateBookAndWriter();

            String BookName = ".*" + bookAndWriter.Item3.Book.Name + ".*";
            Dictionary<string, object> bookDict = new Dictionary<string, object>();
         

            var queryBook = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Book {Name:'" + bookAndWriter.Item1.Name
                                                           + "', Genre:'" + bookAndWriter.Item1.Genre + "', Publisher:'" + bookAndWriter.Item1.Publisher
                                                           + "', YearOfPublish:'" + bookAndWriter.Item1.YearOfPublish
                                                           + "', Summary:'" + bookAndWriter.Item1.Summary
                                                           +"', NumberOfPages:'" + bookAndWriter.Item1.NumberOfPages
                                                           + "'}) return n",
                                                           bookDict, CypherResultMode.Set);
            List<Book> books = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(queryBook).ToList();

            String WriterName = bookAndWriter.Item2.Name;
            Dictionary<string, object> writerDict = new Dictionary<string, object>();
          

            var queryWriter = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Writer {Name:'" + bookAndWriter.Item2.Name
                                                          + "', Lastname:'" + bookAndWriter.Item2.Lastname 
                                                          + "', Birthday:'" + bookAndWriter.Item2.Birthday
                                                          + "', Biography:'" + bookAndWriter.Item2.Biography                                             
                                                          + "'}) return n",
                                                          writerDict, CypherResultMode.Set);
            List<Writer> writers = ((IRawGraphClient)client).ExecuteGetCypherResults<Writer>(queryWriter).ToList();


            
            String InterestingFacts = bookAndWriter.Item3.InterestingFacts;
            Dictionary<string, object> bookWriterDict = new Dictionary<string, object>();
            bookWriterDict.Add("InterestingFacts", bookAndWriter.Item3.InterestingFacts);
            bookWriterDict.Add("BookName", BookName);
            bookWriterDict.Add("WriterName", bookAndWriter.Item3.Writer.Name);



            var queryBookWriter = new Neo4jClient.Cypher.CypherQuery("MATCH (b:Book), (w:Writer) WHERE b.Name =~ {BookName} " +
                                                                     "AND w.Name =~ {WriterName} " +
                                                                     "CREATE (w)-[r:WROTE {InterestingFacts:{InterestingFacts}}]->(b)" +
                                                                     "RETURN r{Book:b, Writer:w}",
                                             bookWriterDict, CypherResultMode.Set);
            List<BookWriter> bookWriters = ((IRawGraphClient)client).ExecuteGetCypherResults<BookWriter>(queryBookWriter).ToList();


            Dictionary<string, object> bookUserDict = new Dictionary<string, object>();
            bookUserDict.Add("Book", bookAndWriter.Item4.Book);
            bookUserDict.Add("User", bookAndWriter.Item4.User);
            bookUserDict.Add("UploadDate", bookAndWriter.Item4.UploadDate);
            bookUserDict.Add("Username", bookAndWriter.Item4.User.Username);
            bookUserDict.Add("BookName", bookAndWriter.Item4.Book.Name);


            String UploadDate = bookAndWriter.Item4.UploadDate.ToString();
            String Username = bookAndWriter.Item4.User.Username;
            var queryBookUser = new Neo4jClient.Cypher.CypherQuery("MATCH (b:Book), (u:User) WHERE b.Name =~ {BookName} " +
                                                                     "AND u.Username =~ {Username} " +
                                                                     "CREATE (b)-[r:UPLOADEDBY {UploadDate:{UploadDate}}]->(u)" +
                                                                     "RETURN r{Book:b, User:u}",
                                             bookUserDict, CypherResultMode.Set);

            List<BookUser> bookUser = ((IRawGraphClient)client).ExecuteGetCypherResults<BookUser>(queryBookUser).ToList();


        }

        private void bookNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(bookNameTextBox.Text))
            {
                e.Cancel = true;
                bookNameTextBox.Focus();
                errorProvider1.SetError(bookNameTextBox, "Book name is required!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(bookNameTextBox, null);
            }
        }

        private void writerNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(writerNameTextBox.Text))
            {
                e.Cancel = true;
                writerNameTextBox.Focus();
                errorProvider2.SetError(writerNameTextBox, "Writer's name is required!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(writerNameTextBox, null);
            }
        }

        private void writerLastnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(writerLastnameTextBox.Text))
            {
                e.Cancel = true;
                writerLastnameTextBox.Focus();
                errorProvider3.SetError(writerLastnameTextBox, "Writer's last name is required!");

            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(writerLastnameTextBox, null);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.client = client;
            bookForm.ShowDialog();

        }
    }
}
