using Neo4jClient;
using System.Windows.Forms;

namespace BookClub
{
    public partial class MainForm : Form
    {
        public GraphClient client;
        public MainForm()
        {
            InitializeComponent();
        }

        private void reviewButton_Click(object sender, System.EventArgs e)
        {
            
        }

        private void booksButton_Click(object sender, System.EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.client = client;
            bookForm.ShowDialog();
        }

        private void quotesButton_Click(object sender, System.EventArgs e)
        {
            QuoteForm quoteForm = new QuoteForm();
            quoteForm.client = client;
            quoteForm.ShowDialog();
        }
    }
}
