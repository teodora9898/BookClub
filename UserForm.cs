using Neo4jClient;
using System;
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

        }

        private void signUpUser(object sender, MouseEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.client = client;
            signUpForm.ShowDialog();
        }
    }
}
