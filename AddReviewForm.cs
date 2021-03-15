using BookClub.Domain_models;
using BookClub.Help;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookClub
{
    public partial class bookComboBox : Form
    {
        public GraphClient client;
        public bookComboBox()
        {
            InitializeComponent();
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (b:Book) return distinct b",
                                                         new Dictionary<string, object>(), CypherResultMode.Set);

            List<Book> books = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            foreach (Book b in books)
            {
                reviewComboBox.Items.Add(b.Name);
            }
        }

        private Tuple<Review, UserReview, BookReview> createReview()
        {
            Review review = new Review()
            {
                Text = reviewTextBox.Text
            };
            UserReview userReview = new UserReview()
            {
                Review = review,
                User = Global.ActiveUser,
                UploadDate = DateTime.Now
            };
            BookReview bookReview = new BookReview();
            var bookTitle = reviewComboBox.Text;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH(n: Book) WHERE n.Name = '" + bookTitle + "' RETURN n",
                                                            queryDict, CypherResultMode.Set);
            Book book1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).FirstOrDefault();
            bookReview.Book = book1;
            bookReview.Review = review;

            return new Tuple<Review, UserReview, BookReview>(review, userReview, bookReview);
        }

        private void addReviewBtn_Click(object sender, EventArgs e)
        {
            if (reviewComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a book you want to add review for!");
                return;
            }

            Tuple<Review, UserReview, BookReview> review = this.createReview();
            
            Dictionary<string, object> queryReviewDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Review {Text:'" + review.Item1.Text +
                                                            "'}) return n",
                                                            queryReviewDict, CypherResultMode.Set);

            List<Review> quotes = ((IRawGraphClient)client).ExecuteGetCypherResults<Review>(query).ToList();

            foreach (Review r in quotes)
            {
                MessageBox.Show("Successfully added review!");
            }

            Dictionary<string, object> queryUserReviewDict = new Dictionary<string, object>();
            queryUserReviewDict.Add("Text", review.Item2.Review.Text);
            queryUserReviewDict.Add("Username", review.Item2.User.Username);

            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (a:User),(b:Review)" +
                                                            "WHERE a.Username =~ {Username} AND b.Text =~ {Text} CREATE(a) -[r:UPPLOADED]->(b)" +
                                                             "RETURN r{User:a, Review:b}",
                                                            queryUserReviewDict, CypherResultMode.Set);
            
            List<UserReview> quotes2 = ((IRawGraphClient)client).ExecuteGetCypherResults<UserReview>(query2).ToList();

            Dictionary<string, object> queryBookReviewDict = new Dictionary<string, object>();
            queryBookReviewDict.Add("ReviewText", review.Item3.Review.Text);
            queryBookReviewDict.Add("Title", review.Item3.Book.Name);

            var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (a:Review),(b:Book)" +
                                                            "WHERE a.Text =~ {ReviewText} AND b.Name =~ {Title} CREATE(a) -[r:IS_FROM]->(b)" +
                                                             "RETURN r{Review:a, Book:b}",
                                                           queryBookReviewDict, CypherResultMode.Set);

            List<UserReview> quotes3 = ((IRawGraphClient)client).ExecuteGetCypherResults<UserReview>(query3).ToList();
        }
    }
}
