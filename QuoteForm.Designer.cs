
namespace BookClub
{
    partial class QuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myQuoteButton = new System.Windows.Forms.Button();
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.Quotes = new System.Windows.Forms.ListBox();
            this.Books = new System.Windows.Forms.ListBox();
            this.deleteQuoteBtn = new System.Windows.Forms.Button();
            this.findQuotesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myQuoteButton
            // 
            this.myQuoteButton.Location = new System.Drawing.Point(56, 32);
            this.myQuoteButton.Name = "myQuoteButton";
            this.myQuoteButton.Size = new System.Drawing.Size(147, 64);
            this.myQuoteButton.TabIndex = 0;
            this.myQuoteButton.Text = "My qoutes";
            this.myQuoteButton.UseVisualStyleBackColor = true;
            this.myQuoteButton.Click += new System.EventHandler(this.myQuoteButton_Click);
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Location = new System.Drawing.Point(56, 112);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(147, 64);
            this.addQuoteButton.TabIndex = 2;
            this.addQuoteButton.Text = "Add quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // Quotes
            // 
            this.Quotes.FormattingEnabled = true;
            this.Quotes.ItemHeight = 20;
            this.Quotes.Location = new System.Drawing.Point(290, 32);
            this.Quotes.Name = "Quotes";
            this.Quotes.Size = new System.Drawing.Size(150, 144);
            this.Quotes.TabIndex = 3;
            // 
            // Books
            // 
            this.Books.FormattingEnabled = true;
            this.Books.ItemHeight = 20;
            this.Books.Location = new System.Drawing.Point(506, 32);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(150, 144);
            this.Books.TabIndex = 4;
            // 
            // deleteQuoteBtn
            // 
            this.deleteQuoteBtn.Location = new System.Drawing.Point(56, 192);
            this.deleteQuoteBtn.Name = "deleteQuoteBtn";
            this.deleteQuoteBtn.Size = new System.Drawing.Size(147, 64);
            this.deleteQuoteBtn.TabIndex = 5;
            this.deleteQuoteBtn.Text = "Delete quote";
            this.deleteQuoteBtn.UseVisualStyleBackColor = true;
            this.deleteQuoteBtn.Click += new System.EventHandler(this.deleteQuoteBtn_Click);
            // 
            // findQuotesBtn
            // 
            this.findQuotesBtn.Location = new System.Drawing.Point(56, 272);
            this.findQuotesBtn.Name = "findQuotesBtn";
            this.findQuotesBtn.Size = new System.Drawing.Size(147, 64);
            this.findQuotesBtn.TabIndex = 13;
            this.findQuotesBtn.Text = "Find quotes";
            this.findQuotesBtn.UseVisualStyleBackColor = true;
            this.findQuotesBtn.Click += new System.EventHandler(this.findQuotesBtn_Click);
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findQuotesBtn);
            this.Controls.Add(this.deleteQuoteBtn);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Quotes);
            this.Controls.Add(this.addQuoteButton);
            this.Controls.Add(this.myQuoteButton);
            this.Name = "QuoteForm";
            this.Text = "QuoteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myQuoteButton;
        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.ListBox Quotes;
        private System.Windows.Forms.ListBox Books;
        private System.Windows.Forms.Button deleteQuoteBtn;
        private System.Windows.Forms.Button findQuotesBtn;
    }
}