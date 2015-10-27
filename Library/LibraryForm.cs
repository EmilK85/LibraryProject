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

        public LibraryForm() 
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            mainPanel.Dock = DockStyle.Fill;

            RepositoryFactory bookRepoFactory = new RepositoryFactory();
            _bookService = new BookService(bookRepoFactory);

            RepositoryFactory authorRepoFactory = new RepositoryFactory();
            _authorService = new AuthorService(authorRepoFactory);

            RepositoryFactory memberRepoFactory = new RepositoryFactory();
            _memberService = new MemberService(memberRepoFactory);

            RepositoryFactory loanRepoFactory = new RepositoryFactory();
            _loanService = new LoanService(loanRepoFactory);

            RepositoryFactory bookCopyRepoFactory = new RepositoryFactory();
            _bookCopyService = new BookCopyService(bookCopyRepoFactory);

            CreateLibrary();
            //ListAllAuthors();
            //ListAllMembers();
            //ListAllLoans();
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
            
            //Book monteCristo = new Book()
            //{
            //    Title = "The Count of Monte Cristo",
            //    IsbnNumber = 9781435132115,
            //    NrOfCopies = 7,
            //    Description = description,
            //    author = AlexDumas
            //};

            //Book monteBlisto = new Book()
            //{
            //    Title = "The Count of Monte Blisto",
            //    IsbnNumber = 9781435132114,
            //    NrOfCopies = 6,
            //    Description = descriptionTwo,
            //    author = AlexDumas
            //};

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

        private void ListAllLoans()
        {
            foreach (Loan loan in _loanService.All())
            {
                lbBooks.Items.Add(loan);
            }
        }


        private void bookBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            bookPanel.Visible = true;
            bookPanel.Dock = DockStyle.Fill;
        }

        private void loanBtn_Click(object sender, EventArgs e)
        {

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
            lbBooks.Items.Clear();

            foreach (Book book in _bookService.All())
            {
                lbBooks.Items.Add(book);
            }
        }

        private void listAuthorBtn_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            string authorName = authorInputTb.Text;
            foreach(Book b in _authorService.booksByAuthor(authorName))
            {
                lbBooks.Items.Add(b);
            }
            authorInputTb.Text = "";
            authorInputTb.Focus();
        }

        private void availableBookBtn_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();

            List<BookCopy> bCopyList = new List<BookCopy>();
            foreach(BookCopy bCopy in _bookCopyService.All())
            {
                bCopyList.Add(bCopy);
            }

            List<BookCopy> sortedList = bCopyList.OrderBy(b => b.book.Id).ToList();

            foreach (BookCopy bCopy in sortedList)
            {
                lbBooks.Items.Add(bCopy);
            }
        }

        private void addCopyBtn_Click(object sender, EventArgs e)
        {
            var item = lbBooks.SelectedItem;
            if(item is Book)
            {
                _bookService.AddCopy((Book)item);
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
            Author _author = new Author()
            {
                Name = addBookAuthorTb.Text,
                books = new List<Book>()
            };

            string title = addBookTitleTb.Text;
            long isbn = long.Parse(addBookIsbnTb.Text);
            int nrOfCopies = 0;
            string description = addBookDescTb.Text;

            Book addBook = new Book(_author, title, description, isbn, nrOfCopies);

            //Book addBook = new Book()
            //{
            //    Title = addBookTitleTb.Text,
            //    IsbnNumber = long.Parse(addBookIsbnTb.Text),
            //    NrOfCopies = 0,
            //    Description = addBookDescTb.Text,
            //    author = bookAuthor
            //};
            _author.books.Add(addBook);
            //_bookService.Add(addBook);
            _authorService.Add(_author);
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
            memberLb.Items.Clear();

            foreach (Member member in _memberService.All())
            {
                memberLb.Items.Add(member);
            }
        }

        private void memberLoanBtn_Click(object sender, EventArgs e)
        {
            memberLb.Items.Clear();
            string memberName = searchMemberTb.Text;
            foreach(Loan l in _memberService.LoansByMember(memberName))
            {
                memberLb.Items.Add(l);
            }
            searchMemberTb.Text = "";
            searchMemberTb.Focus();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            string name = memberNameTb.Text;
            int pNumber = int.Parse(pNumberTb.Text);

            Member _member = new Member(pNumber, name);

            _memberService.Add(_member);
            pNumberTb.Text = "";
            memberNameTb.Text = "";
        }

        private void authorHomeBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            authorPanel.Visible = false;
            authorLb.Items.Clear();
        }

        private void allAuthorsBtn_Click(object sender, EventArgs e)
        {
            authorLb.Items.Clear();
            foreach (Author author in _authorService.All())
            {
                authorLb.Items.Add(author);
            }
        }

        private void addAuthorBtn_Click(object sender, EventArgs e)
        {
            string name = authorNameTb.Text;

            Author _author = new Author(name);

            _authorService.Add(_author);
            authorNameTb.Text = "";
        }

        private void loanBtn_Click_1(object sender, EventArgs e)
        {
            string name = memberLoanTb.Text;
            string book = bookLoanTb.Text;
            int bookId;
            int memberId;
            BookCopy bCopy = new BookCopy();
            Member member = new Member();

            foreach(Book b in _bookService.All())
            {
                if(b.Title == book)
                {
                    bookId = b.Id;
                    bCopy = _bookCopyService.Find(bookId);
                }
            }

            foreach (Member m in _memberService.All())
            {
                if (m.Name == name)
                {
                    memberId = m.MemberId;
                    member = _memberService.Find(memberId);
                }
            }

            Loan loan = new Loan(bCopy, member);
            _loanService.Add(loan);
        }

        private void returnLoanBtn_Click(object sender, EventArgs e)
        {
            var item = memberLb.SelectedItem;
            if (item is Loan)
            {
                if(_loanService.ReturnLoan((Loan)item) == 0)
                {
                    MessageBox.Show("Loan returned!");
                }
                else
                {
                    int days = _loanService.ReturnLoan((Loan)item);
                    int fee = days * 10;
                    MessageBox.Show("You owe " + fee + " kr!");
                }
                _loanService.Remove((Loan)item);
            }
        }
    }
}
