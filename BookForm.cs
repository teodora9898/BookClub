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
            String UploadedBy = ".*"+Global.ActiveUser.Username+ ".*";

            Dictionary<string, object> myBooksDict = new Dictionary<string, object>();
            myBooksDict.Add("UploadedBy", UploadedBy);
            
            //todo : smisli query : preko grane ili preko propertija? Mozda je bolje opreko grane?
            var query = new Neo4jClient.Cypher.CypherQuery(" match (w)-[r1:WROTE]->(b)-[r:UPLOADEDBY]->(u) where u.Username =~ {UploadedBy} return r1{Book:b, Writer:w}",
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
            String activeUser = ".*" + Global.ActiveUser.Username + ".*";

            Dictionary<string, object> myBooksDict = new Dictionary<string, object>();
            myBooksDict.Add("ActiveUser", activeUser);

            //todo : smisli query : preko grane ili preko propertija? Mozda je bolje opreko grane?
            var query = new Neo4jClient.Cypher.CypherQuery(" match (w)-[r1:WROTE]->(b)-[r:IS_BOOKMARKED_BY]->(u) where u.Username =~ {ActiveUser} and r.Bookmarked=true return r1{Book:b, Writer:w}",
                                                         myBooksDict, CypherResultMode.Set);
            List<BookWriter> uploadedBooks = ((IRawGraphClient)client).ExecuteGetCypherResults<BookWriter>(query).ToList();

            for (int i = 0; i < uploadedBooks.Count; i++)
            {
                Books.Items.Add(uploadedBooks.ElementAt(i).Book.Name);
                Writers.Items.Add(uploadedBooks.ElementAt(i).Writer.Name + " " + uploadedBooks.ElementAt(i).Writer.Lastname);

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
    }
}
