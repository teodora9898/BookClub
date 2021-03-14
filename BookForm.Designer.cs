﻿namespace BookClub
{
    partial class BookForm
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
            this.myBooksButton = new System.Windows.Forms.Button();
            this.bookBookmarksButton = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.ListBox();
            this.Writers = new System.Windows.Forms.ListBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.SearchBookTextBox = new System.Windows.Forms.TextBox();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.SearchBookListBox = new System.Windows.Forms.ListBox();
            this.BookmarkBookButton = new System.Windows.Forms.Button();
            this.SearchBooksByWriterButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myBooksButton
            // 
            this.myBooksButton.Location = new System.Drawing.Point(133, 94);
            this.myBooksButton.Name = "myBooksButton";
            this.myBooksButton.Size = new System.Drawing.Size(150, 62);
            this.myBooksButton.TabIndex = 0;
            this.myBooksButton.Text = "My books";
            this.myBooksButton.UseVisualStyleBackColor = true;
            this.myBooksButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myBooksButton_MouseClick);
            // 
            // bookBookmarksButton
            // 
            this.bookBookmarksButton.Location = new System.Drawing.Point(133, 220);
            this.bookBookmarksButton.Name = "bookBookmarksButton";
            this.bookBookmarksButton.Size = new System.Drawing.Size(150, 62);
            this.bookBookmarksButton.TabIndex = 0;
            this.bookBookmarksButton.Text = "Book bookmarks";
            this.bookBookmarksButton.UseVisualStyleBackColor = true;
            this.bookBookmarksButton.Click += new System.EventHandler(this.bookBookmarksButton_Click);
            // 
            // Books
            // 
            this.Books.FormattingEnabled = true;
            this.Books.ItemHeight = 20;
            this.Books.Location = new System.Drawing.Point(423, 94);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(232, 184);
            this.Books.TabIndex = 1;
            this.Books.SelectedIndexChanged += new System.EventHandler(this.Books_SelectedIndexChanged);
            // 
            // Writers
            // 
            this.Writers.FormattingEnabled = true;
            this.Writers.ItemHeight = 20;
            this.Writers.Location = new System.Drawing.Point(712, 94);
            this.Writers.Name = "Writers";
            this.Writers.Size = new System.Drawing.Size(232, 184);
            this.Writers.TabIndex = 1;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(133, 399);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(150, 60);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "Add book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // SearchBookTextBox
            // 
            this.SearchBookTextBox.Location = new System.Drawing.Point(586, 399);
            this.SearchBookTextBox.Name = "SearchBookTextBox";
            this.SearchBookTextBox.Size = new System.Drawing.Size(162, 27);
            this.SearchBookTextBox.TabIndex = 3;
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.Location = new System.Drawing.Point(586, 449);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(110, 54);
            this.SearchBookButton.TabIndex = 4;
            this.SearchBookButton.Text = "Search book by name";
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // SearchBookListBox
            // 
            this.SearchBookListBox.FormattingEnabled = true;
            this.SearchBookListBox.ItemHeight = 20;
            this.SearchBookListBox.Location = new System.Drawing.Point(794, 399);
            this.SearchBookListBox.Name = "SearchBookListBox";
            this.SearchBookListBox.Size = new System.Drawing.Size(150, 104);
            this.SearchBookListBox.TabIndex = 5;
            // 
            // BookmarkBookButton
            // 
            this.BookmarkBookButton.Location = new System.Drawing.Point(794, 519);
            this.BookmarkBookButton.Name = "BookmarkBookButton";
            this.BookmarkBookButton.Size = new System.Drawing.Size(94, 29);
            this.BookmarkBookButton.TabIndex = 6;
            this.BookmarkBookButton.Text = "Bookmark";
            this.BookmarkBookButton.UseVisualStyleBackColor = true;
            this.BookmarkBookButton.Click += new System.EventHandler(this.BookmarkBookButton_Click);
            // 
            // SearchBooksByWriterButton
            // 
            this.SearchBooksByWriterButton.Location = new System.Drawing.Point(586, 530);
            this.SearchBooksByWriterButton.Name = "SearchBooksByWriterButton";
            this.SearchBooksByWriterButton.Size = new System.Drawing.Size(110, 48);
            this.SearchBooksByWriterButton.TabIndex = 7;
            this.SearchBooksByWriterButton.Text = "Search books by writer";
            this.SearchBooksByWriterButton.UseVisualStyleBackColor = true;
            this.SearchBooksByWriterButton.Click += new System.EventHandler(this.SearchBooksByWriterButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Location = new System.Drawing.Point(423, 298);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(94, 53);
            this.DeleteBookButton.TabIndex = 8;
            this.DeleteBookButton.Text = "Delete book";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 599);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.SearchBooksByWriterButton);
            this.Controls.Add(this.BookmarkBookButton);
            this.Controls.Add(this.SearchBookListBox);
            this.Controls.Add(this.SearchBookButton);
            this.Controls.Add(this.SearchBookTextBox);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.Writers);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.bookBookmarksButton);
            this.Controls.Add(this.myBooksButton);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myBooksButton;
        private System.Windows.Forms.Button bookBookmarksButton;
        private System.Windows.Forms.ListBox Books;
        private System.Windows.Forms.ListBox Writers;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox SearchBookTextBox;
        private System.Windows.Forms.Button SearchBookButton;
        private System.Windows.Forms.ListBox SearchBookListBox;
        private System.Windows.Forms.Button BookmarkBookButton;
        private System.Windows.Forms.Button SearchBooksByWriterButton;
        private System.Windows.Forms.Button DeleteBookButton;
    }
}