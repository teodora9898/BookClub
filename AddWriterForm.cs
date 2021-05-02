using BookClub.Domain_models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookClub
{
    public partial class AddWriterForm : Form
    {
        public GraphClient client;
        public AddWriterForm()
        {
            InitializeComponent();
        }

        private void AddWriterButton_Click(object sender, EventArgs e)
        {
            string name = writerNameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            string birthday = dateTimePicker1.Value.ToShortDateString();
            string biography = biographyTextBox.Text;

            Writer writer = new Writer
            {
                Name = name,
                Lastname = lastname,
                Birthday = birthday,
                Biography = biography,


            };

            var queryWriter = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Writer {Name:'" + writer.Name
                                                          + "', Lastname:'" + writer.Lastname
                                                          + "', Birthday:'" + writer.Birthday
                                                          + "', Biography:'" + writer.Biography
                                                          + "'}) return n",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<Writer> writers = ((IRawGraphClient)client).ExecuteGetCypherResults<Writer>(queryWriter).ToList();
            MessageBox.Show("Uspesno ste dodali pisca!");

        }

        private void backToAddBookForm_Click(object sender, EventArgs e)
        {
            AddBookForm bookForm = new AddBookForm();
            bookForm.client = client;
            bookForm.ShowDialog();
        }
    }
}
