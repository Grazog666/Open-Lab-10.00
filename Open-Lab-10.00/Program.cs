using System;

namespace Open_Lab_10._00
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Author("Zbyszek");
            LOTR.Category("Fantasy");
            LOTR.ReleaseDate(2030);
            LOTR.Title("´FrostAge");
            LOTR.Pages(1200);
            LOTR.Returner();


        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string author;
        private string category;
        private int releaseDate;
        public void Title(string setTitle)
        {
            title = setTitle;
        }
        public void Pages(int setPages)
        {
            pages = setPages;
        }
        public void Author(string setAuthor)
        {
            author = setAuthor;
        }
        public void ReleaseDate(int setReleaseDate)
        {
            releaseDate = setReleaseDate;
        }
        public void Category (string setCategory)
        {
            category = setCategory;
        }
        public void Returner()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
            Console.WriteLine(category);

        }
    }
}
