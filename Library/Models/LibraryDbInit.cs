//Emil Kronström & Love Hermansson
//OOP2
//02/11 -15
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Library.Models 
{
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> 
    {
        protected override void Seed(LibraryContext context) 
        {
            base.Seed(context);

            //string description = "The story of Edmund Dantes, self-styled Count of Monte Cristo, is told with consummate skill."; 
            //                       //The victim of a miscarriage of justice, Dantes is fired by a desire for retribution and 
            //                       //empowered by a stroke of providence. In his campaign of vengeance, he becomes an anonymous 
            //                       //agent of fate. The sensational narrative of intrigue, betrayal, escape, and triumphant revenge 
            //                       //moves at a cracking pace. Dumas' novel presents a powerful conflict between good and evil 
            //                       //embodied in an epic saga of rich diversity that is complicated by the hero's ultimate 
            //                       //discomfort with the hubristic implication of his own actions.";

            ////description = Regex.Replace(description, @"\s+", " ");
            
            //Author AlexDumas = new Author()
            //{
            //    Name = "Alexander Dumas"
            //};
            //context.Authors.Add(AlexDumas);
            //context.SaveChanges();

            ////Book monteCristo = new Book() 
            ////{
            ////    Title = "The Count of Monte Cristo",
            ////    IsbnNumber = 9781435132115,
            ////    NrOfCopies = 7,
            ////    Description = description,
            ////    author = new Author() { Name = "AuthorMan" }
            ////};

            //Book monteCristo = new Book(AlexDumas, "The Count of Monte Cristo", description, 9781435132115, 7);

            //// Add the book to the DbSet of books.
            //context.Books.Add(monteCristo);

            //// Persist changes to the database
            //context.SaveChanges();
        }
    }
}
