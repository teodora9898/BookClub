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

namespace BookClub
{
    public partial class BookForm : Form
    {
        
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
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (b:Book)-[r:UPLOADED_BY]->(u:User) where u.Username =~ {UpoladedBy} return b",
                                                         myBooksDict, CypherResultMode.Set);

            

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
