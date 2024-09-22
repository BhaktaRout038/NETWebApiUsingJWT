using NETWebApiUsingJWT.Model;

namespace NETWebApiUsingJWT.Services
{
    public class UserServices
    {
        public static async Task<UserDetails> UserAuthentication(UserBE userBE)
        {
            if (userBE != null)
            {
                if (userBE.UserID == "alpha" & userBE.Password == "alpha@123")
                {
                    return new UserDetails
                    {
                        UserName = "Tonny"
                    };
                }
            }

            return null;
        }

        public static List<Book> GetBoookList(int UserId)
        {
            return new List<Book>
{
    new Book { BookID = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", YearPublished = 1925, IsAlloted = true },
    new Book { BookID = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", YearPublished = 1960, IsAlloted = false },
    new Book { BookID = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian", YearPublished = 1949, IsAlloted = true },
    new Book { BookID = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", YearPublished = 1813, IsAlloted = true },
    new Book { BookID = 5, Title = "Moby Dick", Author = "Herman Melville", Genre = "Adventure", YearPublished = 1851, IsAlloted = false },
    new Book { BookID = 6, Title = "War and Peace", Author = "Leo Tolstoy", Genre = "Historical", YearPublished = 1869, IsAlloted = true },
    new Book { BookID = 7, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", YearPublished = 1951, IsAlloted = true },
    new Book { BookID = 8, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", YearPublished = 1937, IsAlloted = false },
    new Book { BookID = 9, Title = "Fahrenheit 451", Author = "Ray Bradbury", Genre = "Dystopian", YearPublished = 1953, IsAlloted = true },
    new Book { BookID = 10, Title = "Brave New World", Author = "Aldous Huxley", Genre = "Science Fiction", YearPublished = 1932, IsAlloted = true },
    new Book { BookID = 11, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Genre = "Psychological Fiction", YearPublished = 1866, IsAlloted = false },
    new Book { BookID = 12, Title = "The Odyssey", Author = "Homer", Genre = "Epic", YearPublished = -800, IsAlloted = true },
    new Book { BookID = 13, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Genre = "Fantasy", YearPublished = 1954, IsAlloted = false },
    new Book { BookID = 14, Title = "Jane Eyre", Author = "Charlotte Brontë", Genre = "Romance", YearPublished = 1847, IsAlloted = true },
    new Book { BookID = 15, Title = "Wuthering Heights", Author = "Emily Brontë", Genre = "Romance", YearPublished = 1847, IsAlloted = false },
    new Book { BookID = 16, Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky", Genre = "Philosophical Fiction", YearPublished = 1880, IsAlloted = true },
    new Book { BookID = 17, Title = "Anna Karenina", Author = "Leo Tolstoy", Genre = "Realist Fiction", YearPublished = 1877, IsAlloted = true },
    new Book { BookID = 18, Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", Genre = "Magic Realism", YearPublished = 1967, IsAlloted = false },
    new Book { BookID = 19, Title = "The Divine Comedy", Author = "Dante Alighieri", Genre = "Epic Poetry", YearPublished = 1320, IsAlloted = true },
    new Book { BookID = 20, Title = "The Count of Monte Cristo", Author = "Alexandre Dumas", Genre = "Adventure", YearPublished = 1844, IsAlloted = false }
};
        }
    }
}
