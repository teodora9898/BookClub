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
    public partial class SignInForm : Form
    {
        public GraphClient client;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void signIn(object sender, MouseEventArgs e)
        {
            String Username = ".*" + usernameInput.Text + ".*";
            String Password = ".*" + passwordInput.Text + ".*";

            Dictionary<string, object> signInQueryDict = new Dictionary<string, object>();
            signInQueryDict.Add("Username", Username);
            signInQueryDict.Add("Password", Password);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n:User) where n.Password =~ {Password} and n.Username =~ {Username} return n",
                                                           signInQueryDict, CypherResultMode.Set);

            List<User> users = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            if(users.Count == 0)
            {
                MessageBox.Show("Username ili Password nisu ispravni! Pokusajte ponovo!");
            }
            else
            {
                Help.Global.ActiveUser = users.ElementAt(0);
                MessageBox.Show("Uspesno ste se prijavili!");
                //QuoteForm quoteForm = new QuoteForm();
                //quoteForm.client = client;
                //quoteForm.ShowDialog();

                BookForm bookForm = new BookForm();
                bookForm.client = client;
                bookForm.ShowDialog();

                //MainUserForm mainuserForm = new MainUserForm();
                //mainuserForm.client = client;
                //mainuserForm.ShowDialog();
            }

        }

        private void signInButton_Click(object sender, EventArgs e)
        {

        }
    }
}
