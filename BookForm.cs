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
            String UploadedBy = Global.ActiveUser.Username;

            Dictionary<string, object> myBooksDict = new Dictionary<string, object>();
            myBooksDict.Add("UploadedBy", UploadedBy);
            
            //todo : smisli query : preko grane ili preko propertija? Mozda je bolje opreko grane?
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (b)-[r:UPLOADED_BY]->(u) where u.Username =~ {UpoladedBy} return r{Book:b}",
                                                         myBooksDict, CypherResultMode.Set);

            List<BookUser> uploadedBooks = ((IRawGraphClient)client).ExecuteGetCypherResults<BookUser>(query).ToList();

            
            Dictionary<string, object> bookWriterDict = new Dictionary<string, object>();
            List<BookWriter> writers;
            foreach (var book in uploadedBooks)
            {
                Books.Items.Add(book.Book.Name);
                bookWriterDict.Add("BookName", book.Book.Name);
                var queryWriters = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (w)-[r:WROTE]->(b) where b.Name =~ {BookName} return r{Writer:w}",
                     bookWriterDict, CypherResultMode.Set);
                 writers = ((IRawGraphClient)client).ExecuteGetCypherResults<BookWriter>(queryWriters).ToList();
                Writers.Items.Add(writers.ElementAt(0).Writer.Name + " " + writers.ElementAt(0).Writer.Lastname);
                bookWriterDict.Remove("BookName");

            }

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
