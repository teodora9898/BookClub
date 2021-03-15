using BookClub.Domain_models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BookClub.Help;
using Neo4jClient.Cypher;
using Neo4jClient;
using System.Linq;

namespace BookClub
{
    public partial class BookForm : Form
    {
        public GraphClient client;
        public BookForm()
        {
            InitializeComponent();
        }

        private void myBooksButton_MouseClick(object sender, MouseEventArgs e)
        {
            Books.Items.Clear();
            Books.Items.Clear();

            String UploadedBy = Global.ActiveUser.Username;

            Dictionary<string, object> myBooksDict = new Dictionary<string, object>();
            myBooksDict.Add("UploadedBy", UploadedBy);
            
            //todo : smisli query : preko grane ili preko propertija? Mozda je bolje opreko grane?
            var query = new Neo4jClient.Cypher.CypherQuery(" match (w)-[r1:WROTE]->(b)-[r:UPLOADEDBY]->(u) where u.Username = {UploadedBy} return r1{Book:b, Writer:w}",
                                                         myBooksDict, CypherResultMode.Set);
            List<BookWriter> uploadedBooks = ((IRawGraphClient)client).ExecuteGetCypherResults<BookWriter>(query).ToList();

            for (int i = 0; i<uploadedBooks.Count; i++)
            {
                Books.Items.Add(uploadedBooks.ElementAt(i).Book.Name);
                Writers.Items.Add(uploadedBooks.ElementAt(i).Writer.Name + " " + uploadedBooks.ElementAt(i).Writer.Lastname);
               
            }
           
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
           

        }

        private void bookBookmarksButton_Click(object sender, EventArgs e)
        {
            Books.Items.Clear();
            Writers.Items.Clear();

            String activeUser =  Global.ActiveUser.Username.ToString();

            Dictionary<string, object> myBooksDict = new Dictionary<string, object>();
            myBooksDict.Add("activeUser", activeUser);

            //todo : smisli query : preko grane ili preko propertija? Mozda je bolje opreko grane?
            var query = new Neo4jClient.Cypher.CypherQuery(" match (w)-[r1:WROTE]->(b)<-[r:BOOKMARK]-(u) where u.Username = {activeUser} return r1{Book:b, Writer:w}",
                                                         myBooksDict, CypherResultMode.Set);
            List<BookWriter> bookmarkedBooks = ((IRawGraphClient)client).ExecuteGetCypherResults<BookWriter>(query).ToList();

            for (int i = 0; i < bookmarkedBooks.Count; i++)
            {
                if (!Books.Items.Contains(bookmarkedBooks.ElementAt(i).Book.Name))
                {
                    Books.Items.Add(bookmarkedBooks.ElementAt(i).Book.Name);
                    Writers.Items.Add(bookmarkedBooks.ElementAt(i).Writer.Name + " " + bookmarkedBooks.ElementAt(i).Writer.Lastname);
                }
            }
           


        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.client = client;
            addBookForm.ShowDialog();
        }

        private void Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBook = Books.SelectedItem;
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            SearchBookListBox.Items.Clear();
            string bookName = ".*" +"(?i)"+ SearchBookTextBox.Text + ".*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("bookName", bookName);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Book) and exists(n.Name) and n.Name =~ {bookName} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Book> books = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            foreach (Book b in books)
            {
                SearchBookListBox.Items.Add(b.Name);
            }
        }

        private void BookmarkBookButton_Click(object sender, EventArgs e)
        {
            String bookName =  SearchBookListBox.SelectedItem.ToString();
            String activeUser = Help.Global.ActiveUser.Username.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("bookName", bookName);
            queryDict.Add("activeUser", activeUser);

            var queryIf = new Neo4jClient.Cypher.CypherQuery("MATCH (b:Book{Name:{bookName}})<-[r:BOOKMARK]-(u:User{Username:{activeUser}}) " +
                                                                                 "RETURN r{Book:b, User:u}",
                                                         queryDict, CypherResultMode.Set);
            List<Book> bookIf = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(queryIf).ToList();
            if (bookIf.Count != 0)
            {
                MessageBox.Show("This book is already bookmarked");
            }
            else
            {


                var queryBookmark = new Neo4jClient.Cypher.CypherQuery("MATCH (b:Book), (u:User) WHERE b.Name = {bookName} " +
                                                                         "AND u.Username = {activeUser}" +
                                                                         "CREATE (u)-[r:BOOKMARK]->(b)" +
                                                                         "RETURN r{Book:b, User:u}",
                                                 queryDict, CypherResultMode.Set);
                List<Book> book = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(queryBookmark).ToList();
            }


        }

        private void SearchBooksByWriterButton_Click(object sender, EventArgs e)
        {
            SearchBookListBox.Items.Clear();
            string[] subs = SearchBookTextBox.Text.Split(' ');
            string writersNameSubstring1 = ".*" + "(?i)" +subs[0] + ".*";
            string writersNameSubstring2=null;
            if (subs.Count() == 2)
            {
                 writersNameSubstring2 = ".*" + "(?i)" + SearchBookTextBox.Text.Split(new[] { ' ' }, 2)[1] + ".*";
            }



            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("writerName", writersNameSubstring1);
            queryDict.Add("writerLastname", writersNameSubstring2);

            var query = new Neo4jClient.Cypher.CypherQuery("match (w:Writer)-[:WROTE]->(b:Book) where" +
                                                            " (w.Name =~ {writerName} or w.Lastname =~ {writerName}) or" +
                                                            " (w.Name =~ {writerName} and w.Lastname =~ {writerLastname}) return b",
                                                            queryDict, CypherResultMode.Set);

            List<Book> books = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            foreach (Book b in books)
            {
                SearchBookListBox.Items.Add(b.Name);
            }
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            String bookToDelete = Books.SelectedItem.ToString();
            int index = Books.SelectedIndex;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("bookName", bookToDelete);



            var query = new Neo4jClient.Cypher.CypherQuery("match (b:Book) where b.Name = {bookName} detach delete b",
                                                            queryDict, CypherResultMode.Projection);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query);

            Books.Items.RemoveAt(index);
            Writers.Items.RemoveAt(index);

        }

        private void BackToMainFormBookButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.client = client;
            mainForm.ShowDialog();
        }
    }
}
