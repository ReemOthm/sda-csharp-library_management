namespace LibraryManagementSystem;

class Library
{
    private List<User> _users;
    private List<Book> _books;

    private INotificationService _notificationService;

    public Library(INotificationService notificationService)
    {
        _users = new List<User>();
        _books = new List<Book>();
        this._notificationService = notificationService;
    }

    public List<Book> FindBooksByTitle(string title)
    {
        return _books.FindAll(i => i.Title.Contains(title, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<User> FindUsersByName(string name)
    {
        return _users.FindAll(i => i.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public void AddBook(Book book)
    {
        try
        {
            bool id = _books.Any(item => item.Id == book.Id);
            if (id)
            {
                _notificationService.SendNotificationOnFailure($"adding Book '{book.Title}', thus it is already exsisting!");
                return;
            }
            _books.Add(book);
            _notificationService.SendNotificationOnSucess($"a new book '{book.Title}' has been added");

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
                _notificationService.SendNotificationOnFailure($"adding user '{user.Name}', thus it is already existing.");
                return;
            }
            _users.Add(user);
            _notificationService.SendNotificationOnSucess($"A new user '{user.Name}' has been added to");

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
                _notificationService.SendNotificationOnFailure($"deleted user '{user.Name}'");
                return;
            }
            _users.Remove(user);
            _notificationService.SendNotificationOnSucess($"'{user.Name}' has deleted from");

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
                _notificationService.SendNotificationOnFailure($"deleted Book '{book.Title}'");
                return;
            }
            _books.Remove(book);
            _notificationService.SendNotificationOnSucess($"Book '{book.Title}' has deleted");

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

    // With Pagination 
    public List<User> GetAllUsers(int pageNumber, int limitPerPage)
    {
        return _users.OrderBy(i => i.CreatedDate).Skip((pageNumber - 1) * limitPerPage).Take(limitPerPage).ToList();
    }

    public void GetAllBooks()
    {
        List<Book> list = [.. _books.OrderBy(i => i.CreatedDate)];
        _books.ForEach(Console.WriteLine);
    }

    // With Pagination 
    public List<Book> GetAllBooks(int pageNumber, int limitPerPage)
    {
        return _books.OrderBy(i => i.CreatedDate).Skip((pageNumber - 1) * limitPerPage).Take(limitPerPage).ToList();
    }

}
