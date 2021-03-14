namespace BookClub
{
    partial class MainUserForm
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
            this.Followers = new System.Windows.Forms.ListBox();
            this.Following = new System.Windows.Forms.ListBox();
            this.UnfollowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NotFollowing = new System.Windows.Forms.ListBox();
            this.followButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Followers
            // 
            this.Followers.FormattingEnabled = true;
            this.Followers.ItemHeight = 20;
            this.Followers.Location = new System.Drawing.Point(47, 58);
            this.Followers.Name = "Followers";
            this.Followers.Size = new System.Drawing.Size(122, 64);
            this.Followers.TabIndex = 0;
            // 
            // Following
            // 
            this.Following.FormattingEnabled = true;
            this.Following.ItemHeight = 20;
            this.Following.Location = new System.Drawing.Point(199, 58);
            this.Following.Name = "Following";
            this.Following.Size = new System.Drawing.Size(129, 64);
            this.Following.TabIndex = 1;
            // 
            // UnfollowButton
            // 
            this.UnfollowButton.Location = new System.Drawing.Point(199, 147);
            this.UnfollowButton.Name = "UnfollowButton";
            this.UnfollowButton.Size = new System.Drawing.Size(94, 29);
            this.UnfollowButton.TabIndex = 2;
            this.UnfollowButton.Text = "Unfollow";
            this.UnfollowButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check item form list, \r\nthen click button below to unfollow\r\n";
            // 
            // NotFollowing
            // 
            this.NotFollowing.FormattingEnabled = true;
            this.NotFollowing.ItemHeight = 20;
            this.NotFollowing.Location = new System.Drawing.Point(538, 58);
            this.NotFollowing.Name = "NotFollowing";
            this.NotFollowing.Size = new System.Drawing.Size(150, 104);
            this.NotFollowing.TabIndex = 4;
            // 
            // followButton
            // 
            this.followButton.Location = new System.Drawing.Point(538, 182);
            this.followButton.Name = "followButton";
            this.followButton.Size = new System.Drawing.Size(94, 29);
            this.followButton.TabIndex = 5;
            this.followButton.Text = "Follow";
            this.followButton.UseVisualStyleBackColor = true;
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.followButton);
            this.Controls.Add(this.NotFollowing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnfollowButton);
            this.Controls.Add(this.Following);
            this.Controls.Add(this.Followers);
            this.Name = "MainUserForm";
            this.Text = "MainUserForm";
            this.Load += new System.EventHandler(this.MainUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Followers;
        private System.Windows.Forms.ListBox Following;
        private System.Windows.Forms.Button UnfollowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NotFollowing;
        private System.Windows.Forms.Button followButton;
    }
}