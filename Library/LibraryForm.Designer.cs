namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.authorBtn = new System.Windows.Forms.Button();
            this.memberBtn = new System.Windows.Forms.Button();
            this.loanBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.bookHome = new System.Windows.Forms.Button();
            this.showBookBtn = new System.Windows.Forms.Button();
            this.listAuthorBtn = new System.Windows.Forms.Button();
            this.authorInputTb = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.bookPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.HorizontalScrollbar = true;
            this.lbBooks.Location = new System.Drawing.Point(3, 3);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(242, 121);
            this.lbBooks.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.authorBtn);
            this.mainPanel.Controls.Add(this.memberBtn);
            this.mainPanel.Controls.Add(this.loanBtn);
            this.mainPanel.Controls.Add(this.bookBtn);
            this.mainPanel.Location = new System.Drawing.Point(510, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(119, 211);
            this.mainPanel.TabIndex = 1;
            // 
            // authorBtn
            // 
            this.authorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorBtn.Location = new System.Drawing.Point(21, 96);
            this.authorBtn.Name = "authorBtn";
            this.authorBtn.Size = new System.Drawing.Size(75, 22);
            this.authorBtn.TabIndex = 3;
            this.authorBtn.Text = "Authors";
            this.authorBtn.UseVisualStyleBackColor = true;
            this.authorBtn.Click += new System.EventHandler(this.authorBtn_Click);
            // 
            // memberBtn
            // 
            this.memberBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.memberBtn.Location = new System.Drawing.Point(21, 67);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(75, 23);
            this.memberBtn.TabIndex = 2;
            this.memberBtn.Text = "Members";
            this.memberBtn.UseVisualStyleBackColor = true;
            this.memberBtn.Click += new System.EventHandler(this.memberBtn_Click);
            // 
            // loanBtn
            // 
            this.loanBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loanBtn.Location = new System.Drawing.Point(21, 38);
            this.loanBtn.Name = "loanBtn";
            this.loanBtn.Size = new System.Drawing.Size(75, 23);
            this.loanBtn.TabIndex = 1;
            this.loanBtn.Text = "Loans";
            this.loanBtn.UseVisualStyleBackColor = true;
            this.loanBtn.Click += new System.EventHandler(this.loanBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookBtn.Location = new System.Drawing.Point(21, 9);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(75, 23);
            this.bookBtn.TabIndex = 0;
            this.bookBtn.Text = "Books";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // bookPanel
            // 
            this.bookPanel.Controls.Add(this.authorInputTb);
            this.bookPanel.Controls.Add(this.listAuthorBtn);
            this.bookPanel.Controls.Add(this.showBookBtn);
            this.bookPanel.Controls.Add(this.bookHome);
            this.bookPanel.Controls.Add(this.lbBooks);
            this.bookPanel.Location = new System.Drawing.Point(12, 12);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(248, 337);
            this.bookPanel.TabIndex = 2;
            this.bookPanel.Visible = false;
            // 
            // bookHome
            // 
            this.bookHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookHome.Location = new System.Drawing.Point(3, 311);
            this.bookHome.Name = "bookHome";
            this.bookHome.Size = new System.Drawing.Size(75, 23);
            this.bookHome.TabIndex = 1;
            this.bookHome.Text = "Home";
            this.bookHome.UseVisualStyleBackColor = true;
            this.bookHome.Click += new System.EventHandler(this.bookHome_Click);
            // 
            // showBookBtn
            // 
            this.showBookBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showBookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showBookBtn.Location = new System.Drawing.Point(3, 130);
            this.showBookBtn.Name = "showBookBtn";
            this.showBookBtn.Size = new System.Drawing.Size(91, 23);
            this.showBookBtn.TabIndex = 2;
            this.showBookBtn.Text = "Show all books";
            this.showBookBtn.UseVisualStyleBackColor = true;
            this.showBookBtn.Click += new System.EventHandler(this.showBookBtn_Click);
            // 
            // listAuthorBtn
            // 
            this.listAuthorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listAuthorBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listAuthorBtn.Location = new System.Drawing.Point(6, 186);
            this.listAuthorBtn.Name = "listAuthorBtn";
            this.listAuthorBtn.Size = new System.Drawing.Size(88, 23);
            this.listAuthorBtn.TabIndex = 3;
            this.listAuthorBtn.Text = "List by author";
            this.listAuthorBtn.UseVisualStyleBackColor = true;
            this.listAuthorBtn.Click += new System.EventHandler(this.listAuthorBtn_Click);
            // 
            // authorInputTb
            // 
            this.authorInputTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorInputTb.Location = new System.Drawing.Point(6, 160);
            this.authorInputTb.Name = "authorInputTb";
            this.authorInputTb.Size = new System.Drawing.Size(100, 20);
            this.authorInputTb.TabIndex = 4;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 496);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.mainPanel.ResumeLayout(false);
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Button loanBtn;
        private System.Windows.Forms.Button authorBtn;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button bookHome;
        private System.Windows.Forms.Button showBookBtn;
        private System.Windows.Forms.Button listAuthorBtn;
        private System.Windows.Forms.TextBox authorInputTb;
    }
}

