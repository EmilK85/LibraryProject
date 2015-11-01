using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library 
{
    public partial class LibraryForm : Form 
    {
        BookService _bookService;
        BookCopyService _bookCopyService;
        AuthorService _authorService;
        MemberService _memberService;
        LoanService _loanService;
        int selectedIndex = 0;

        public LibraryForm() 
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            mainPanel.Dock = DockStyle.Fill;

            RepositoryFactory bookRepoFactory = new RepositoryFactory();
            _bookService = new BookService(bookRepoFactory);
            _bookService.Updated += showBookBtn_Click;

            RepositoryFactory authorRepoFactory = new RepositoryFactory();
            _authorService = new AuthorService(authorRepoFactory);
            _authorService.Updated += allAuthorsBtn_Click;

            RepositoryFactory memberRepoFactory = new RepositoryFactory();
            _memberService = new MemberService(memberRepoFactory);
            _memberService.Updated += allMemberBtn_Click;

            RepositoryFactory loanRepoFactory = new RepositoryFactory();
            _loanService = new LoanService(loanRepoFactory);
            _loanService.Updated += memberLoanBtn_Click;

            RepositoryFactory bookCopyRepoFactory = new RepositoryFactory();
            _bookCopyService = new BookCopyService(bookCopyRepoFactory);
            _bookCopyService.Updated += showBookBtn_Click;

            CreateLibrary();
        }

        public void CreateLibrary()
        {
            Author AlexDumas = new Author()
            {
                Name = "Alexander Dumas",
                books = new List<Book>()
            };

            Author JamesJoyce = new Author()
            {
                Name = "James Joyce",
                books = new List<Book>()
            };

            string description = "The story of Edmund Dantes, self-styled Count of Monte Cristo, is told with consummate skill.";
            string descriptionTwo = "This is a description";
            string descriptionThree = "It was the best of times, it was the worst of times";

            string title = "The Count of Monte Cristo";
            string titleTwo = "The Count of Monte Blisto";
            string titleThree = "Ulysses";

            long isbnOne = 9781435132115;
            long isbnTwo = 9781435132114;
            long isbnThree = 9789100146238;

            int nrOfCopyOne = 7;
            int nrOfCopyTwo = 6;

            Book monteCristo = new Book(AlexDumas, title, description, isbnOne, nrOfCopyOne);
            Book monteBlisto = new Book(AlexDumas, titleTwo, descriptionTwo, isbnTwo, nrOfCopyTwo);
            Book ulysses = new Book(JamesJoyce, titleThree, descriptionThree, isbnThree, nrOfCopyOne);
            
            AlexDumas.books.Add(monteCristo);
            AlexDumas.books.Add(monteBlisto);
            JamesJoyce.books.Add(ulysses);

            _authorService.Add(AlexDumas);
            _authorService.Add(JamesJoyce);
            //_bookService.Add(monteCristo);

            Member Love = new Member()
            {
                Pnumber = 920217,
                Name = "Love",
                loans = new List<Loan>()
            };

            _memberService.Add(Love);

            BookCopy bCopy = _bookCopyService.Find(monteCristo.Id);

            Loan loanTest = new Loan(bCopy, Love);
            _loanService.Add(loanTest);

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            bookPanel.Visible = true;
            bookPanel.Dock = DockStyle.Fill;
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            memberPanel.Visible = true;
            memberPanel.Dock = DockStyle.Fill;
        }

        private void authorBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            authorPanel.Visible = true;
            authorPanel.Dock = DockStyle.Fill;
        }

        private void bookHome_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            bookPanel.Visible = false;
            lbBooks.Items.Clear();
        }

        private void showBookBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                lbBooks.Items.Clear();
                addCopyBtn.Visible = true;
                memberLabel.Visible = true;
                bookLabel.Visible = true;
                memberLoanTb.Visible = true;
                bookLoanTb.Visible = true;
                createLoanBtn.Visible = true;

                foreach (Book book in _bookService.All())
                {
                    lbBooks.Items.Add(book);
                }
                lbBooks.SelectedIndex = selectedIndex;
                lbBooks.Focus();
            }
        }

        private void listAuthorBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                lbBooks.Items.Clear();
                string authorName = authorInputTb.Text;
                foreach (Book b in _authorService.BooksByAuthor(authorName))
                {
                    lbBooks.Items.Add(b);
                }
                authorInputTb.Text = "";
                authorInputTb.Focus();
            }
        }

        private void availableBookBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                lbBooks.Items.Clear();
                addCopyBtn.Visible = false;
                memberLabel.Visible = false;
                bookLabel.Visible = false;
                memberLoanTb.Visible = false;
                bookLoanTb.Visible = false;
                createLoanBtn.Visible = false;

                List<BookCopy> bCopyList = _bookCopyService.AvailableBooks();
                foreach (BookCopy bCopy in bCopyList)
                {
                    lbBooks.Items.Add(bCopy);
                }
            }
        }

        private void addCopyBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                var item = lbBooks.SelectedItem;
                selectedIndex = lbBooks.SelectedIndex;
                if (item is Book)
                {
                    _bookService.AddCopy((Book)item);
                }
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            bookPanel.Visible = false;
            mainPanel.Visible = false;
            addBookPanel.Visible = true;
            addBookPanel.Dock = DockStyle.Fill;
        }

        private void addBookBookBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                string author = addBookAuthorTb.Text;
                string title = addBookTitleTb.Text;
                string isbn = addBookIsbnTb.Text;
                string description = addBookDescTb.Text;

                if(!_bookService.TryAdd(author, title, isbn, description))
                {
                    MessageBox.Show("You forgot to enter information");
                }
               
                addBookAuthorTb.Text = "";
                addBookTitleTb.Text = "";
                addBookIsbnTb.Text = "";
                addBookDescTb.Text = "";
            }
        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            bookPanel.Visible = true;
            addBookPanel.Visible = false;
        }

        private void memberReturnBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            memberPanel.Visible = false;
            memberLb.Items.Clear();
        }

        private void allMemberBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                memberLb.Items.Clear();

                foreach (Member member in _memberService.All())
                {
                    memberLb.Items.Add(member);
                }
            }
        }

        private void memberLoanBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                memberLb.Items.Clear();
                string memberName = "";
                memberName = searchMemberTb.Text;
                List<Loan> loanList = _loanService.LoansByMember(memberName);
                foreach (Loan l in loanList)
                {
                    memberLb.Items.Add(l);
                }
                //searchMemberTb.Text = "";
                //searchMemberTb.Focus();
            }
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                string name = memberNameTb.Text;
                int pNumber = int.Parse(pNumberTb.Text);

                Member _member = new Member(pNumber, name);

                _memberService.Add(_member);
                pNumberTb.Text = "";
                memberNameTb.Text = "";
            }
        }

        private void authorHomeBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            authorPanel.Visible = false;
            authorLb.Items.Clear();
        }

        private void allAuthorsBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                authorLb.Items.Clear();
                foreach (Author author in _authorService.All())
                {
                    authorLb.Items.Add(author);
                }
            }
        }

        private void addAuthorBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                string name = authorNameTb.Text;
                Author _author = new Author(name);

                _authorService.Add(_author);
                authorNameTb.Text = "";
            }
        }

        private void returnLoanBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                var item = memberLb.SelectedItem;
                if (item is Loan)
                {
                    string message = _loanService.ReturnLoan((Loan)item);
                    MessageBox.Show(message);
                }
            }
        }

        private void createLoanBtn_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Visible)
            {
                string name = memberLoanTb.Text;
                string title = bookLoanTb.Text;

                string message = _loanService.CreateLoan(name, title);

                if(message == "Success")
                {
                    _bookService.OnUpdated(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void loanBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            loanPanel.Visible = true;
            loanPanel.Dock = DockStyle.Fill;
        }

        private void loanHomeBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            loanPanel.Visible = false;
        }

        private void modLoanBtn_Click(object sender, EventArgs e)
        {
            var item = memberLb.SelectedItem;
            selectedIndex = memberLb.SelectedIndex;
            if (item is Loan)
            {
                _loanService.ModLoan((Loan)item);
            }
        }
    }
}
