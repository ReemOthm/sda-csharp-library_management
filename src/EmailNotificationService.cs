namespace LibraryManagementSystem;

class EmailNotificationService : INotificationService
{

    public void SendNotificationOnSucess(string message)
    {
        Console.WriteLine($"Hello, A {message} successfully to the Library.\nIf you have any queries or feedback, please contact our support team at support@library.com.\n");
    }

    public void SendNotificationOnFailure(string message)
    {
        Console.WriteLine($"We encountered an issue {message}. Please review the input data. For more help, visit our FAQ at library.com/faq\n");

    }

}