using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml =
                    "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Script", Role = "Dan Slott"},
                    new Artist() {Name = "Pencils", Role = "Humberto Ramos"},
                    new Artist() {Name = "Inks", Role = "Victor Olazaba"},
                    new Artist() {Name = "Colors", Role = "Edgar Delgado"},
                    new Artist() {Name = "Letters", Role = "Chris Eliopoulos"}
                }
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml =
                    "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Script", Role = "Dan Slott"},
                    new Artist() {Name = "Pencils", Role = "Humberto Ramos"},
                    new Artist() {Name = "Inks", Role = "Victor Olazaba"},
                    new Artist() {Name = "Colors", Role = "Edgar Delgado"},
                    new Artist() {Name = "Letters", Role = "Chris Eliopoulos"}
                }
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml =
                    "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Script", Role = "Dan Slott"},
                    new Artist() {Name = "Pencils", Role = "Humberto Ramos"},
                    new Artist() {Name = "Inks", Role = "Victor Olazaba"},
                    new Artist() {Name = "Colors", Role = "Edgar Delgado"},
                    new Artist() {Name = "Letters", Role = "Chris Eliopoulos"}
                }
            }
        };

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}