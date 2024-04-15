namespace LibraryManagementSystem;

class SMSNotificationService : INotificationService
{
    public void SendNotificationOnFailure(string message)
    {
        Console.WriteLine($"Error {message}'. Please email support@library.com.\n");
    }

    public void SendNotificationOnSucess(string message)
    {
        Console.WriteLine($"{message} added to Library. Thank you!\n");
    }
}