﻿
namespace BookClub
{
    partial class MainForm
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
            this.reviewButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.quotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(107, 55);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(94, 29);
            this.reviewButton.TabIndex = 0;
            this.reviewButton.Text = "Reviews";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.Location = new System.Drawing.Point(107, 129);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(94, 29);
            this.booksButton.TabIndex = 1;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // quotesButton
            // 
            this.quotesButton.Location = new System.Drawing.Point(107, 204);
            this.quotesButton.Name = "quotesButton";
            this.quotesButton.Size = new System.Drawing.Size(94, 29);
            this.quotesButton.TabIndex = 3;
            this.quotesButton.Text = "Quotes";
            this.quotesButton.UseVisualStyleBackColor = true;
            this.quotesButton.Click += new System.EventHandler(this.quotesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quotesButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.reviewButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button quotesButton;
    }
}