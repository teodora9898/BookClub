using BookClub.Domain_models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookClub
{
    public partial class SignUpForm : Form
    {
        public GraphClient client;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignIn(object sender, MouseEventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            User u = new User();

            u.Name = nameTextBox.Text;
            u.Lastname = surnameTextBox.Text;
            u.Username = usernameTextBox.Text;
            u.Password = passwordTextBox.Text;


            Dictionary<string, object> signUpQueryDict = new Dictionary<string, object>();
            signUpQueryDict.Add("Name", u.Name);
            signUpQueryDict.Add("Lastname", u.Lastname);
            signUpQueryDict.Add("Username", u.Username);
            signUpQueryDict.Add("Password",u.Password);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n:User) where n.Username =~ {Username} return n",
                                                           signUpQueryDict, CypherResultMode.Set);

            List<User> users = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            if (users.Count == 0)
            {
                var querySignIn = new Neo4jClient.Cypher.CypherQuery("CREATE (n:User {Name: '" + u.Name + "', Lastname: '" + u.Lastname
                                                            + "', Username: '" + u.Username + "', Password: '" + u.Password
                                                            + "'}) return n",
                                                            signUpQueryDict, CypherResultMode.Set);
                List<User> us = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(querySignIn).ToList();

                //Help.Global.ActiveUser = users.Add(u);
                MessageBox.Show("Uspesno ste se registrovali!");
            }
            else
            {
                MessageBox.Show("Username koji ste uneli već postoji. Molimo unesite drugi!");
            }
        }
    }
}
