namespace LibraryManagementSystem;

class Library
{
    private List<User> _users = [];
    private List<Book> _books = [];

    public void FindBookByTitle(string title)
    {
        var book = _books.FirstOrDefault(i => i.Title.Equals(title, StringComparison.CurrentCultureIgnoreCase));
        if (book == null)
        {
            Console.WriteLine($"Book '{title}' Can Not Found!");
            return;
        }
        Console.WriteLine(book.ToString());
    }

    public void FindUserByName(string name)
    {
        var user = _users.FirstOrDefault(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        if (user == null)
        {
            Console.WriteLine($"User '{name}' Can Not Found!");
            return;
        }
        Console.WriteLine(user.ToString());
    }
    public void AddBook(Book book)
    {
        try
        {
            bool id = _books.Any(item => item.Id == book.Id);
            if (id)
            {
                throw new Exception($"'{book.Title}' is already existing.");
            }
            _books.Add(book);
            Console.WriteLine($"'{book.Title}' has been added successfully!");

        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
    public void AddUser(User user)
    {
        try
        {
            bool id = _users.Any(item => item.Id == user.Id);
            if (id)
            {
                throw new Exception($"'{user.Name}' is already existing.");
            }
            _users.Add(user);
            Console.WriteLine($"'{user.Name}' has been added successfully!");

        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }

    public void DeleteUser(User user)
    {
        try
        {
            bool id = _users.Any(item => item.Id == user.Id);
            if (!id)
            {
                throw new Exception($"'{user.Name}' is not Found!");
            }
            _users.Remove(user);
            Console.WriteLine($"'{user.Name}' has deleted successfully!");

        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
    public void DeleteBook(Book book)
    {
        try
        {
            bool id = _books.Any(item => item.Id == book.Id);
            if (!id)
            {
                throw new Exception($"'{book.Title}' is not Found!");
            }
            _books.Remove(book);
            Console.WriteLine($"'{book.Title}' has deleted successfully!");

        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }

    public void GetAllUsers()
    {
        List<User> list = [.. _users.OrderBy(i => i.CreatedDate)];
        _users.ForEach(Console.WriteLine);
    }
    public void GetAllBooks()
    {
        List<Book> list = [.. _books.OrderBy(i => i.CreatedDate)];
        _books.ForEach(Console.WriteLine);
    }

}