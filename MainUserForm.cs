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
    public partial class MainUserForm : Form
    {
        public GraphClient client;
        public MainUserForm()
        {
            InitializeComponent();
        }

        private void MainUserForm_Load(object sender, EventArgs e)
        {
            //todo ogranicenje da username morada bude jedinstven, uradi ako nisi uradila!!!!
            //String activeUsername =".*"+ Help.Global.ActiveUser.Username+".*";
            //Dictionary<string, object> dict = new Dictionary<string, object>();
            //dict.Add("userName", activeUsername);

            //var query = new Neo4jClient.Cypher.CypherQuery("match (u:User) where not u.Username = {userName} return u",
            //                                           dict, CypherResultMode.Set);

            //List<User> following = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            //foreach (User u in following)
            //{
            //    NotFollowing.Items.Add(u.Username);
            //}
        }
    }
}
