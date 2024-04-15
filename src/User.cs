namespace LibraryManagementSystem;

class User(string name, DateTime createdDate = default) : BaseClass(createdDate)
{
    public string Name { get; set; } = name;

}