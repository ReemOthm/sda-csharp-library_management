namespace LibraryManagementSystem;

class User(string name, DateTime createdDate = default) : BaseClass(createdDate)
{
    public string Name { get; set; } = name;

    public override string ToString()
    {
        return $"{{User Name: {Name} , Id: {Id} , Created Date: {CreatedDate} }}";
    }
}