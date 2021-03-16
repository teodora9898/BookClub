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
    public partial class WritersForm : Form
    {
        public GraphClient client;

        public WritersForm()
        {
            InitializeComponent();
        }

        private void WritersForm_Load(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (w:Writer) return distinct w",
                                                        new Dictionary<string, object>(), CypherResultMode.Set);

            List<Writer> writers = ((IRawGraphClient)client).ExecuteGetCypherResults<Writer>(query).ToList();

            foreach (Writer u in writers)
            {
                allWritersComboBox.Items.Add(u.Name + " " + u.Lastname);
            }
        }

        private void allWritersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            writersBiographyTextBox.Clear();

            String writer = allWritersComboBox.SelectedItem.ToString();
            String writersName = writer.Split(' ')[0].ToString();
            String writersLastname = writer.Split(' ')[1].ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("name", writersName);
            queryDict.Add("lastname", writersLastname);

            var query = new Neo4jClient.Cypher.CypherQuery("match (w:Writer) where w.Name = {name} and w.Lastname = {lastname} return w",
                                                       queryDict, CypherResultMode.Set);

            List<Writer> writers = ((IRawGraphClient)client).ExecuteGetCypherResults<Writer>(query).ToList();

            writersBiographyTextBox.Text = writers[0].Biography;
        }

        private void UpdateWritersBiographyButton_Click(object sender, EventArgs e)
        {

            if (allWritersComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose the writer first!");
                return;
            }

            String modifiedBiography = writersBiographyTextBox.Text.ToString();
            String writer = allWritersComboBox.SelectedItem.ToString();
            String writersName = writer.Split(' ')[0].ToString();
            String writersLastname = writer.Split(' ')[1].ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("biography", modifiedBiography);
            queryDict.Add("name", writersName);
            queryDict.Add("lastname", writersLastname);


            var query = new Neo4jClient.Cypher.CypherQuery("match (w:Writer {Name:{name}, Lastname:{lastname}}) " +
                                                           "set w.Biography = {biography} return w",
                                                       queryDict, CypherResultMode.Set);

            List<Writer> writers = ((IRawGraphClient)client).ExecuteGetCypherResults<Writer>(query).ToList();

            if(writers.Count!=0)
            {
                writersBiographyTextBox.Text = writers[0].Biography;
            }



        }

        private void DeleteWriterButton_Click(object sender, EventArgs e)
        {
            
            String writer = allWritersComboBox.SelectedItem.ToString();
            int index = allWritersComboBox.SelectedIndex;
            String writersName = writer.Split(' ')[0].ToString();
            String writersLastname = writer.Split(' ')[1].ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("writerName", writersName);
            queryDict.Add("writerLastname", writersLastname);



            var query = new Neo4jClient.Cypher.CypherQuery("match (w:Writer{Name:{writerName} , Lastname:{writerLastname}})" +
                                                             "optional match (w)-[r:WROTE]->(b:Book)"+
                                                             " detach delete b, w",
                                                            queryDict, CypherResultMode.Projection);

            ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query);

            allWritersComboBox.Items.RemoveAt(index);
            writersBiographyTextBox.Clear();
        }

        private void BackToMainFormWriterButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.client = client;
            mainForm.ShowDialog();
        }
    }
}
