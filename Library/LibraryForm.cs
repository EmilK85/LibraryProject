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

        private void ListAllMembers()
        {
            foreach(Member member in _memberService.All())
            {
                lbBooks.Items.Add(member);
            }
        }

        private void ListAllLoans()
        {
            foreach (Loan loan in _loanService.All())
            {
                lbBooks.Items.Add(loan);
            }
        }

        private void ListAllAuthors()
        {
            foreach(Author author in _authorService.All())
            {
                lbBooks.Items.Add(author);
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

        }

        private void authorBtn_Click(object sender, EventArgs e)
        {

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


    }
}
