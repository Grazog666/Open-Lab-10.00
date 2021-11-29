using System;

namespace Open_Lab_10._00
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
           
            LOTR._Pages = 304;
            LOTR._Title = ("Lord of the rings");
            LOTR._Author = ("Tolkien");
            LOTR._Category = ("Fantasy");
            LOTR._ReleaseDate = 2002;
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

        public int _Pages
        {
           get { return pages; }
            set 
            { 
                if (value > 0)
                {
                    pages = value;
                }
                else 
                {
                    pages = 1;
                }
            }
        }
        public string _Title
        {
            get { return title; }
            set { title = value; }
        }

        public string _Author
        {
            get { return author; }
            set { author =value ; }
        }

        public string _Category
        {
            get { return category; }
            set { category = value; }
        }

        public int _ReleaseDate
        {
            get { return releaseDate; }
            set 
            { 
                if (value <= 2021 && value >= 1450 )
                {
                    releaseDate = value;
                }
                else 
                {
                    releaseDate = -1;
                }
            }
            
        }





        public void Returner()
        {
            Console.WriteLine(_Title);
            Console.WriteLine(_Pages);
            Console.WriteLine(_Author);
            Console.WriteLine(_ReleaseDate);
            Console.WriteLine(_Category);

        }
    }
}
