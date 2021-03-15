
namespace BookClub
{
    partial class AddQuoteForm
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
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.quoteTextBox = new System.Windows.Forms.RichTextBox();
            this.quoteComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Location = new System.Drawing.Point(274, 299);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(188, 29);
            this.addQuoteButton.TabIndex = 0;
            this.addQuoteButton.Text = "Add quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // quoteTextBox
            // 
            this.quoteTextBox.Location = new System.Drawing.Point(274, 120);
            this.quoteTextBox.Name = "quoteTextBox";
            this.quoteTextBox.Size = new System.Drawing.Size(188, 145);
            this.quoteTextBox.TabIndex = 1;
            this.quoteTextBox.Text = "";
            // 
            // quoteComboBox
            // 
            this.quoteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quoteComboBox.FormattingEnabled = true;
            this.quoteComboBox.Location = new System.Drawing.Point(274, 59);
            this.quoteComboBox.Name = "quoteComboBox";
            this.quoteComboBox.Size = new System.Drawing.Size(188, 28);
            this.quoteComboBox.TabIndex = 2;
            this.quoteComboBox.SelectedIndexChanged += new System.EventHandler(this.quoteComboBox_SelectedIndexChanged);
            // 
            // AddQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quoteComboBox);
            this.Controls.Add(this.quoteTextBox);
            this.Controls.Add(this.addQuoteButton);
            this.Name = "AddQuoteForm";
            this.Text = "AddQuoteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.RichTextBox quoteTextBox;
        private System.Windows.Forms.ComboBox quoteComboBox;
    }
}