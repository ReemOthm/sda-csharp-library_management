namespace LibraryManagementSystem;

class Book(string title, DateTime createdDate = default) : BaseClass(createdDate)
{
    public string Title { get; set; } = title;

}