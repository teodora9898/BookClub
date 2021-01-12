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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookClub
{
    public partial class UserForm : Form
    {
        private GraphClient client;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "edukacija");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void signInUser(object sender, MouseEventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.client = client;
            signInForm.ShowDialog();
            //User user = new User
            //{
            //    Name = "David",
            //    Lastname = "Bosnic",
            //    Username = "Dejvid",
            //    Password = "dijazIkortez"
            //};

            //Dictionary<string, object> queryDict = new Dictionary<string, object>();
            //queryDict.Add("Name", user.Name);
            //queryDict.Add("Lastname", user.Lastname);
            //queryDict.Add("Username", user.Username);
            //queryDict.Add("Password", user.Password);

            //var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:User {Name:'" + user.Name
            //                                                + "', Lastname:'" + user.Lastname + "', Username:'" + user.Username
            //                                                + "', Password:'" + user.Password
            //                                                + "'}) return n",
            //                                                queryDict, CypherResultMode.Set);

            //List<User> users = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            //foreach (User u in users)
            //{
            //    MessageBox.Show(u.Name);
            //}

            ////NodeReference<Actor> newActor = client.Create(actor);

            //this.Close();

        }

        private void signUpUser(object sender, MouseEventArgs e)
        {

        }
    }
}
