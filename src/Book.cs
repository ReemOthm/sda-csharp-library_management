namespace LibraryManagementSystem;

class Book(string title, DateTime createdDate = default) : BaseClass(createdDate)
{
    public string Title { get; set; } = title;
    public override string ToString()
    {
        return $"{{Book Title: {Title} , Id: {Id} , Created Date: {CreatedDate} }}";
    }
}