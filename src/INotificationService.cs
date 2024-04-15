namespace LibraryManagementSystem;

interface INotificationService
{
    void SendNotificationOnSucess(string title);

    void SendNotificationOnFailure(string title);
}