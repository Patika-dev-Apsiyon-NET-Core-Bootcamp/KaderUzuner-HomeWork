using System.Collections.Generic;
using System.Linq;
using BookInSession.Models;

namespace BookInSession.Database
{
    public static class Books
    {
        private static List<BookViewModel> _books;
        static Books()
        {
            _books = new List<BookViewModel>()
            {
                new BookViewModel(){Name = "Suç ve Ceza", Author = "Fyodor Dostoyevski",PublishYear= 1866,  CategoryId = 1},
                new BookViewModel(){ Name = "Kuyucaklı Yusuf", Author = "Sabahattin Ali",PublishYear= 1937,  CategoryId = 3},
                new BookViewModel(){Name = "Hayvan Çiftliği", Author = "George Orwell",PublishYear= 1945, CategoryId = 2},
                new BookViewModel(){ Name = "Yüzbaşının Kızı", Author = "Aleksandr Puşkin", PublishYear= 1836, CategoryId = 2},
                new BookViewModel(){Name = "Satranç", Author = "Stefan Zweig", PublishYear= 1943, CategoryId = 2},
                new BookViewModel(){ Name = "Huzusuzluk", Author = "Zülfü Livaneli",PublishYear= 2017,  CategoryId = 3},
                new BookViewModel(){ Name = "Yabancı", Author="Albert Camus",PublishYear= 1942,CategoryId=1 },
            };
        }

        public static List<BookViewModel> BookList
        {
            get
            {
                return _books;
            }
        }
      
    }

}