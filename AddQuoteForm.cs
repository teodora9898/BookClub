using BookClub.Domain_models;
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
    }
}
