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
        public void Title(string gettitle)
        {
            title = gettitle;
        }
        public void Pages(int getpages)
        {
            pages = getpages;
        }
        public void Author(string getauthor)
        {
            author = getauthor;
        }
        public void ReleaseDate(int getreleaseDate)
        {
            releaseDate = getreleaseDate;
        }
        public void Category (string getcategory)
        {
            category = getcategory;
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
