namespace BookClub
{
    partial class AddBookForm
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
            this.components = new System.ComponentModel.Container();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookGenreTextBox = new System.Windows.Forms.TextBox();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numberOfPagesnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearOfPublishnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.backButton = new System.Windows.Forms.Button();
            this.writersComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addWriterFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPagesnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfPublishnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(175, 43);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(143, 27);
            this.bookNameTextBox.TabIndex = 0;
            this.bookNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookNameTextBox_Validating);
            // 
            // bookGenreTextBox
            // 
            this.bookGenreTextBox.Location = new System.Drawing.Point(175, 111);
            this.bookGenreTextBox.Name = "bookGenreTextBox";
            this.bookGenreTextBox.Size = new System.Drawing.Size(143, 27);
            this.bookGenreTextBox.TabIndex = 0;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(175, 429);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(253, 173);
            this.summaryTextBox.TabIndex = 0;
            this.summaryTextBox.TextChanged += new System.EventHandler(this.summaryTextBox_TextChanged);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(175, 179);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(143, 27);
            this.publisherTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Year of publish";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Number of pages";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(525, 644);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 51);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // numberOfPagesnumericUpDown
            // 
            this.numberOfPagesnumericUpDown.Location = new System.Drawing.Point(175, 335);
            this.numberOfPagesnumericUpDown.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numberOfPagesnumericUpDown.Name = "numberOfPagesnumericUpDown";
            this.numberOfPagesnumericUpDown.Size = new System.Drawing.Size(67, 27);
            this.numberOfPagesnumericUpDown.TabIndex = 14;
            // 
            // yearOfPublishnumericUpDown
            // 
            this.yearOfPublishnumericUpDown.Location = new System.Drawing.Point(175, 263);
            this.yearOfPublishnumericUpDown.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.yearOfPublishnumericUpDown.Name = "yearOfPublishnumericUpDown";
            this.yearOfPublishnumericUpDown.Size = new System.Drawing.Size(67, 27);
            this.yearOfPublishnumericUpDown.TabIndex = 15;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(33, 666);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(79, 44);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // writersComboBox
            // 
            this.writersComboBox.FormattingEnabled = true;
            this.writersComboBox.Location = new System.Drawing.Point(664, 110);
            this.writersComboBox.Name = "writersComboBox";
            this.writersComboBox.Size = new System.Drawing.Size(151, 28);
            this.writersComboBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Choose writer\'s name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "If you can not find desired writer, please add it";
            // 
            // addWriterFormButton
            // 
            this.addWriterFormButton.Location = new System.Drawing.Point(664, 223);
            this.addWriterFormButton.Name = "addWriterFormButton";
            this.addWriterFormButton.Size = new System.Drawing.Size(94, 29);
            this.addWriterFormButton.TabIndex = 20;
            this.addWriterFormButton.Text = "Add writer";
            this.addWriterFormButton.UseVisualStyleBackColor = true;
            this.addWriterFormButton.Click += new System.EventHandler(this.addWriterFormButton_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 722);
            this.Controls.Add(this.addWriterFormButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.writersComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.yearOfPublishnumericUpDown);
            this.Controls.Add(this.numberOfPagesnumericUpDown);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.bookGenreTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPagesnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfPublishnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox bookGenreTextBox;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.NumericUpDown numberOfPagesnumericUpDown;
        private System.Windows.Forms.NumericUpDown yearOfPublishnumericUpDown;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox writersComboBox;
        private System.Windows.Forms.Button addWriterFormButton;
    }
}