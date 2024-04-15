using System.ComponentModel;

namespace LibraryManagementSystem;

abstract class BaseClass(DateTime createdDate = default)
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime CreatedDate { get; set; } = createdDate == default ? DateTime.Now : createdDate;
}