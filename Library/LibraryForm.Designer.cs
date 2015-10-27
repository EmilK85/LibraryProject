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
            this.bookBtn = new System.Windows.Forms.Button();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.addCopyBtn = new System.Windows.Forms.Button();
            this.availableBookBtn = new System.Windows.Forms.Button();
            this.authorInputTb = new System.Windows.Forms.TextBox();
            this.listAuthorBtn = new System.Windows.Forms.Button();
            this.showBookBtn = new System.Windows.Forms.Button();
            this.bookHome = new System.Windows.Forms.Button();
            this.addBookPanel = new System.Windows.Forms.Panel();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.addBookBookBtn = new System.Windows.Forms.Button();
            this.bookIsbnLabel = new System.Windows.Forms.Label();
            this.addBookIsbnTb = new System.Windows.Forms.TextBox();
            this.addBookDescTb = new System.Windows.Forms.TextBox();
            this.bookDescLabel = new System.Windows.Forms.Label();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.addBookTitleTb = new System.Windows.Forms.TextBox();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.addBookAuthorTb = new System.Windows.Forms.TextBox();
            this.memberPanel = new System.Windows.Forms.Panel();
            this.pNumberTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memberNameTb = new System.Windows.Forms.TextBox();
            this.memberLoanBtn = new System.Windows.Forms.Button();
            this.searchMemberTb = new System.Windows.Forms.TextBox();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.memberReturnBtn = new System.Windows.Forms.Button();
            this.allMemberBtn = new System.Windows.Forms.Button();
            this.memberLb = new System.Windows.Forms.ListBox();
            this.authorPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.authorNameTb = new System.Windows.Forms.TextBox();
            this.authorHomeBtn = new System.Windows.Forms.Button();
            this.addAuthorBtn = new System.Windows.Forms.Button();
            this.allAuthorsBtn = new System.Windows.Forms.Button();
            this.authorLb = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.memberLoanTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookLoanTb = new System.Windows.Forms.TextBox();
            this.loanBtn = new System.Windows.Forms.Button();
            this.returnLoanBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.bookPanel.SuspendLayout();
            this.addBookPanel.SuspendLayout();
            this.memberPanel.SuspendLayout();
            this.authorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.HorizontalScrollbar = true;
            this.lbBooks.Location = new System.Drawing.Point(16, 42);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(117, 147);
            this.lbBooks.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.authorBtn);
            this.mainPanel.Controls.Add(this.memberBtn);
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
            this.authorBtn.Location = new System.Drawing.Point(21, 67);
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
            this.memberBtn.Location = new System.Drawing.Point(21, 38);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(75, 23);
            this.memberBtn.TabIndex = 2;
            this.memberBtn.Text = "Members";
            this.memberBtn.UseVisualStyleBackColor = true;
            this.memberBtn.Click += new System.EventHandler(this.memberBtn_Click);
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
            this.bookPanel.Controls.Add(this.loanBtn);
            this.bookPanel.Controls.Add(this.bookLoanTb);
            this.bookPanel.Controls.Add(this.label5);
            this.bookPanel.Controls.Add(this.memberLoanTb);
            this.bookPanel.Controls.Add(this.label4);
            this.bookPanel.Controls.Add(this.addBookBtn);
            this.bookPanel.Controls.Add(this.addCopyBtn);
            this.bookPanel.Controls.Add(this.availableBookBtn);
            this.bookPanel.Controls.Add(this.authorInputTb);
            this.bookPanel.Controls.Add(this.listAuthorBtn);
            this.bookPanel.Controls.Add(this.showBookBtn);
            this.bookPanel.Controls.Add(this.bookHome);
            this.bookPanel.Controls.Add(this.lbBooks);
            this.bookPanel.Location = new System.Drawing.Point(493, 255);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(136, 133);
            this.bookPanel.TabIndex = 2;
            this.bookPanel.Visible = false;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBookBtn.Location = new System.Drawing.Point(28, 125);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(75, 23);
            this.addBookBtn.TabIndex = 7;
            this.addBookBtn.Text = "Add book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // addCopyBtn
            // 
            this.addCopyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCopyBtn.Location = new System.Drawing.Point(-53, 125);
            this.addCopyBtn.Name = "addCopyBtn";
            this.addCopyBtn.Size = new System.Drawing.Size(75, 23);
            this.addCopyBtn.TabIndex = 6;
            this.addCopyBtn.Text = "Add copies";
            this.addCopyBtn.UseVisualStyleBackColor = true;
            this.addCopyBtn.Click += new System.EventHandler(this.addCopyBtn_Click);
            // 
            // availableBookBtn
            // 
            this.availableBookBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.availableBookBtn.Location = new System.Drawing.Point(44, 96);
            this.availableBookBtn.Name = "availableBookBtn";
            this.availableBookBtn.Size = new System.Drawing.Size(121, 23);
            this.availableBookBtn.TabIndex = 5;
            this.availableBookBtn.Text = "Show available books";
            this.availableBookBtn.UseVisualStyleBackColor = true;
            this.availableBookBtn.Click += new System.EventHandler(this.availableBookBtn_Click);
            // 
            // authorInputTb
            // 
            this.authorInputTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorInputTb.Location = new System.Drawing.Point(-53, 154);
            this.authorInputTb.Name = "authorInputTb";
            this.authorInputTb.Size = new System.Drawing.Size(100, 20);
            this.authorInputTb.TabIndex = 4;
            // 
            // listAuthorBtn
            // 
            this.listAuthorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listAuthorBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listAuthorBtn.Location = new System.Drawing.Point(-53, 180);
            this.listAuthorBtn.Name = "listAuthorBtn";
            this.listAuthorBtn.Size = new System.Drawing.Size(88, 23);
            this.listAuthorBtn.TabIndex = 3;
            this.listAuthorBtn.Text = "List by author";
            this.listAuthorBtn.UseVisualStyleBackColor = true;
            this.listAuthorBtn.Click += new System.EventHandler(this.listAuthorBtn_Click);
            // 
            // showBookBtn
            // 
            this.showBookBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showBookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showBookBtn.Location = new System.Drawing.Point(-53, 96);
            this.showBookBtn.Name = "showBookBtn";
            this.showBookBtn.Size = new System.Drawing.Size(91, 23);
            this.showBookBtn.TabIndex = 2;
            this.showBookBtn.Text = "Show all books";
            this.showBookBtn.UseVisualStyleBackColor = true;
            this.showBookBtn.Click += new System.EventHandler(this.showBookBtn_Click);
            // 
            // bookHome
            // 
            this.bookHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookHome.Location = new System.Drawing.Point(-53, 209);
            this.bookHome.Name = "bookHome";
            this.bookHome.Size = new System.Drawing.Size(75, 23);
            this.bookHome.TabIndex = 1;
            this.bookHome.Text = "Home";
            this.bookHome.UseVisualStyleBackColor = true;
            this.bookHome.Click += new System.EventHandler(this.bookHome_Click);
            // 
            // addBookPanel
            // 
            this.addBookPanel.Controls.Add(this.returnBookBtn);
            this.addBookPanel.Controls.Add(this.addBookBookBtn);
            this.addBookPanel.Controls.Add(this.bookIsbnLabel);
            this.addBookPanel.Controls.Add(this.addBookIsbnTb);
            this.addBookPanel.Controls.Add(this.addBookDescTb);
            this.addBookPanel.Controls.Add(this.bookDescLabel);
            this.addBookPanel.Controls.Add(this.bookTitleLabel);
            this.addBookPanel.Controls.Add(this.addBookTitleTb);
            this.addBookPanel.Controls.Add(this.bookAuthorLabel);
            this.addBookPanel.Controls.Add(this.addBookAuthorTb);
            this.addBookPanel.Location = new System.Drawing.Point(12, 12);
            this.addBookPanel.Name = "addBookPanel";
            this.addBookPanel.Size = new System.Drawing.Size(152, 287);
            this.addBookPanel.TabIndex = 3;
            this.addBookPanel.Visible = false;
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.Location = new System.Drawing.Point(4, 232);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(75, 23);
            this.returnBookBtn.TabIndex = 9;
            this.returnBookBtn.Text = "Return";
            this.returnBookBtn.UseVisualStyleBackColor = true;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // addBookBookBtn
            // 
            this.addBookBookBtn.Location = new System.Drawing.Point(51, 186);
            this.addBookBookBtn.Name = "addBookBookBtn";
            this.addBookBookBtn.Size = new System.Drawing.Size(75, 23);
            this.addBookBookBtn.TabIndex = 8;
            this.addBookBookBtn.Text = "Add book";
            this.addBookBookBtn.UseVisualStyleBackColor = true;
            this.addBookBookBtn.Click += new System.EventHandler(this.addBookBookBtn_Click);
            // 
            // bookIsbnLabel
            // 
            this.bookIsbnLabel.AutoSize = true;
            this.bookIsbnLabel.Location = new System.Drawing.Point(37, 144);
            this.bookIsbnLabel.Name = "bookIsbnLabel";
            this.bookIsbnLabel.Size = new System.Drawing.Size(35, 13);
            this.bookIsbnLabel.TabIndex = 7;
            this.bookIsbnLabel.Text = "ISBN:";
            // 
            // addBookIsbnTb
            // 
            this.addBookIsbnTb.Location = new System.Drawing.Point(37, 160);
            this.addBookIsbnTb.Name = "addBookIsbnTb";
            this.addBookIsbnTb.Size = new System.Drawing.Size(100, 20);
            this.addBookIsbnTb.TabIndex = 6;
            // 
            // addBookDescTb
            // 
            this.addBookDescTb.Location = new System.Drawing.Point(37, 121);
            this.addBookDescTb.Name = "addBookDescTb";
            this.addBookDescTb.Size = new System.Drawing.Size(100, 20);
            this.addBookDescTb.TabIndex = 5;
            // 
            // bookDescLabel
            // 
            this.bookDescLabel.AutoSize = true;
            this.bookDescLabel.Location = new System.Drawing.Point(34, 105);
            this.bookDescLabel.Name = "bookDescLabel";
            this.bookDescLabel.Size = new System.Drawing.Size(63, 13);
            this.bookDescLabel.TabIndex = 4;
            this.bookDescLabel.Text = "Description:";
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(37, 66);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.bookTitleLabel.TabIndex = 3;
            this.bookTitleLabel.Text = "Title:";
            // 
            // addBookTitleTb
            // 
            this.addBookTitleTb.Location = new System.Drawing.Point(37, 82);
            this.addBookTitleTb.Name = "addBookTitleTb";
            this.addBookTitleTb.Size = new System.Drawing.Size(100, 20);
            this.addBookTitleTb.TabIndex = 2;
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Location = new System.Drawing.Point(37, 24);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.bookAuthorLabel.TabIndex = 1;
            this.bookAuthorLabel.Text = "Author:";
            // 
            // addBookAuthorTb
            // 
            this.addBookAuthorTb.Location = new System.Drawing.Point(37, 43);
            this.addBookAuthorTb.Name = "addBookAuthorTb";
            this.addBookAuthorTb.Size = new System.Drawing.Size(100, 20);
            this.addBookAuthorTb.TabIndex = 0;
            // 
            // memberPanel
            // 
            this.memberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberPanel.Controls.Add(this.returnLoanBtn);
            this.memberPanel.Controls.Add(this.pNumberTb);
            this.memberPanel.Controls.Add(this.label2);
            this.memberPanel.Controls.Add(this.label1);
            this.memberPanel.Controls.Add(this.memberNameTb);
            this.memberPanel.Controls.Add(this.memberLoanBtn);
            this.memberPanel.Controls.Add(this.searchMemberTb);
            this.memberPanel.Controls.Add(this.addMemberBtn);
            this.memberPanel.Controls.Add(this.memberReturnBtn);
            this.memberPanel.Controls.Add(this.allMemberBtn);
            this.memberPanel.Controls.Add(this.memberLb);
            this.memberPanel.Location = new System.Drawing.Point(180, 29);
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Size = new System.Drawing.Size(282, 446);
            this.memberPanel.TabIndex = 4;
            this.memberPanel.Visible = false;
            // 
            // pNumberTb
            // 
            this.pNumberTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNumberTb.Location = new System.Drawing.Point(149, 312);
            this.pNumberTb.Name = "pNumberTb";
            this.pNumberTb.Size = new System.Drawing.Size(100, 20);
            this.pNumberTb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Social security number";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // memberNameTb
            // 
            this.memberNameTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberNameTb.Location = new System.Drawing.Point(149, 269);
            this.memberNameTb.Name = "memberNameTb";
            this.memberNameTb.Size = new System.Drawing.Size(100, 20);
            this.memberNameTb.TabIndex = 6;
            // 
            // memberLoanBtn
            // 
            this.memberLoanBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberLoanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.memberLoanBtn.Location = new System.Drawing.Point(18, 326);
            this.memberLoanBtn.Name = "memberLoanBtn";
            this.memberLoanBtn.Size = new System.Drawing.Size(100, 23);
            this.memberLoanBtn.TabIndex = 5;
            this.memberLoanBtn.Text = "Loans by member";
            this.memberLoanBtn.UseVisualStyleBackColor = true;
            this.memberLoanBtn.Click += new System.EventHandler(this.memberLoanBtn_Click);
            // 
            // searchMemberTb
            // 
            this.searchMemberTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchMemberTb.Location = new System.Drawing.Point(18, 300);
            this.searchMemberTb.Name = "searchMemberTb";
            this.searchMemberTb.Size = new System.Drawing.Size(100, 20);
            this.searchMemberTb.TabIndex = 4;
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addMemberBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMemberBtn.Location = new System.Drawing.Point(149, 338);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(75, 23);
            this.addMemberBtn.TabIndex = 3;
            this.addMemberBtn.Text = "Add member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // memberReturnBtn
            // 
            this.memberReturnBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberReturnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.memberReturnBtn.Location = new System.Drawing.Point(5, 380);
            this.memberReturnBtn.Name = "memberReturnBtn";
            this.memberReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.memberReturnBtn.TabIndex = 2;
            this.memberReturnBtn.Text = "Home";
            this.memberReturnBtn.UseVisualStyleBackColor = true;
            this.memberReturnBtn.Click += new System.EventHandler(this.memberReturnBtn_Click);
            // 
            // allMemberBtn
            // 
            this.allMemberBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allMemberBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allMemberBtn.Location = new System.Drawing.Point(18, 253);
            this.allMemberBtn.Name = "allMemberBtn";
            this.allMemberBtn.Size = new System.Drawing.Size(100, 23);
            this.allMemberBtn.TabIndex = 1;
            this.allMemberBtn.Text = "Show all members";
            this.allMemberBtn.UseVisualStyleBackColor = true;
            this.allMemberBtn.Click += new System.EventHandler(this.allMemberBtn_Click);
            // 
            // memberLb
            // 
            this.memberLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberLb.FormattingEnabled = true;
            this.memberLb.Location = new System.Drawing.Point(16, 22);
            this.memberLb.Name = "memberLb";
            this.memberLb.Size = new System.Drawing.Size(235, 160);
            this.memberLb.TabIndex = 0;
            // 
            // authorPanel
            // 
            this.authorPanel.Controls.Add(this.label3);
            this.authorPanel.Controls.Add(this.authorNameTb);
            this.authorPanel.Controls.Add(this.authorHomeBtn);
            this.authorPanel.Controls.Add(this.addAuthorBtn);
            this.authorPanel.Controls.Add(this.allAuthorsBtn);
            this.authorPanel.Controls.Add(this.authorLb);
            this.authorPanel.Location = new System.Drawing.Point(28, 382);
            this.authorPanel.Name = "authorPanel";
            this.authorPanel.Size = new System.Drawing.Size(73, 106);
            this.authorPanel.TabIndex = 5;
            this.authorPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // authorNameTb
            // 
            this.authorNameTb.Location = new System.Drawing.Point(106, 236);
            this.authorNameTb.Name = "authorNameTb";
            this.authorNameTb.Size = new System.Drawing.Size(100, 20);
            this.authorNameTb.TabIndex = 4;
            // 
            // authorHomeBtn
            // 
            this.authorHomeBtn.Location = new System.Drawing.Point(4, 371);
            this.authorHomeBtn.Name = "authorHomeBtn";
            this.authorHomeBtn.Size = new System.Drawing.Size(75, 23);
            this.authorHomeBtn.TabIndex = 3;
            this.authorHomeBtn.Text = "Home";
            this.authorHomeBtn.UseVisualStyleBackColor = true;
            this.authorHomeBtn.Click += new System.EventHandler(this.authorHomeBtn_Click);
            // 
            // addAuthorBtn
            // 
            this.addAuthorBtn.Location = new System.Drawing.Point(106, 262);
            this.addAuthorBtn.Name = "addAuthorBtn";
            this.addAuthorBtn.Size = new System.Drawing.Size(75, 23);
            this.addAuthorBtn.TabIndex = 2;
            this.addAuthorBtn.Text = "Add Author";
            this.addAuthorBtn.UseVisualStyleBackColor = true;
            this.addAuthorBtn.Click += new System.EventHandler(this.addAuthorBtn_Click);
            // 
            // allAuthorsBtn
            // 
            this.allAuthorsBtn.Location = new System.Drawing.Point(23, 212);
            this.allAuthorsBtn.Name = "allAuthorsBtn";
            this.allAuthorsBtn.Size = new System.Drawing.Size(75, 23);
            this.allAuthorsBtn.TabIndex = 1;
            this.allAuthorsBtn.Text = "All authors";
            this.allAuthorsBtn.UseVisualStyleBackColor = true;
            this.allAuthorsBtn.Click += new System.EventHandler(this.allAuthorsBtn_Click);
            // 
            // authorLb
            // 
            this.authorLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLb.FormattingEnabled = true;
            this.authorLb.Location = new System.Drawing.Point(23, 8);
            this.authorLb.Name = "authorLb";
            this.authorLb.Size = new System.Drawing.Size(22, 186);
            this.authorLb.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Member";
            // 
            // memberLoanTb
            // 
            this.memberLoanTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.memberLoanTb.Location = new System.Drawing.Point(119, 171);
            this.memberLoanTb.Name = "memberLoanTb";
            this.memberLoanTb.Size = new System.Drawing.Size(100, 20);
            this.memberLoanTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Book";
            // 
            // bookLoanTb
            // 
            this.bookLoanTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookLoanTb.Location = new System.Drawing.Point(122, 211);
            this.bookLoanTb.Name = "bookLoanTb";
            this.bookLoanTb.Size = new System.Drawing.Size(100, 20);
            this.bookLoanTb.TabIndex = 11;
            // 
            // loanBtn
            // 
            this.loanBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loanBtn.Location = new System.Drawing.Point(119, 238);
            this.loanBtn.Name = "loanBtn";
            this.loanBtn.Size = new System.Drawing.Size(75, 23);
            this.loanBtn.TabIndex = 12;
            this.loanBtn.Text = "Loan book";
            this.loanBtn.UseVisualStyleBackColor = true;
            this.loanBtn.Click += new System.EventHandler(this.loanBtn_Click_1);
            // 
            // returnLoanBtn
            // 
            this.returnLoanBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnLoanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnLoanBtn.Location = new System.Drawing.Point(18, 355);
            this.returnLoanBtn.Name = "returnLoanBtn";
            this.returnLoanBtn.Size = new System.Drawing.Size(75, 23);
            this.returnLoanBtn.TabIndex = 10;
            this.returnLoanBtn.Text = "Return loan";
            this.returnLoanBtn.UseVisualStyleBackColor = true;
            this.returnLoanBtn.Click += new System.EventHandler(this.returnLoanBtn_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 496);
            this.Controls.Add(this.authorPanel);
            this.Controls.Add(this.memberPanel);
            this.Controls.Add(this.addBookPanel);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.mainPanel.ResumeLayout(false);
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            this.addBookPanel.ResumeLayout(false);
            this.addBookPanel.PerformLayout();
            this.memberPanel.ResumeLayout(false);
            this.memberPanel.PerformLayout();
            this.authorPanel.ResumeLayout(false);
            this.authorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Button authorBtn;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button bookHome;
        private System.Windows.Forms.Button showBookBtn;
        private System.Windows.Forms.Button listAuthorBtn;
        private System.Windows.Forms.TextBox authorInputTb;
        private System.Windows.Forms.Button availableBookBtn;
        private System.Windows.Forms.Button addCopyBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Panel addBookPanel;
        private System.Windows.Forms.TextBox addBookTitleTb;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.TextBox addBookAuthorTb;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.Button addBookBookBtn;
        private System.Windows.Forms.Label bookIsbnLabel;
        private System.Windows.Forms.TextBox addBookIsbnTb;
        private System.Windows.Forms.TextBox addBookDescTb;
        private System.Windows.Forms.Label bookDescLabel;
        private System.Windows.Forms.Panel memberPanel;
        private System.Windows.Forms.ListBox memberLb;
        private System.Windows.Forms.Button memberLoanBtn;
        private System.Windows.Forms.TextBox searchMemberTb;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.Button memberReturnBtn;
        private System.Windows.Forms.Button allMemberBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberNameTb;
        private System.Windows.Forms.TextBox pNumberTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel authorPanel;
        private System.Windows.Forms.Button authorHomeBtn;
        private System.Windows.Forms.Button addAuthorBtn;
        private System.Windows.Forms.Button allAuthorsBtn;
        private System.Windows.Forms.ListBox authorLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorNameTb;
        private System.Windows.Forms.TextBox bookLoanTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox memberLoanTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loanBtn;
        private System.Windows.Forms.Button returnLoanBtn;
    }
}

