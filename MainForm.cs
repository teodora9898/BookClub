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
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.client = client;
            reviewForm.ShowDialog();
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

        private void WritersButton_Click(object sender, System.EventArgs e)
        {
            WritersForm writersForm = new WritersForm();
            writersForm.client = client;
            writersForm.ShowDialog();
        }
    }
}
