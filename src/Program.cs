﻿namespace LibraryManagementSystem;
internal class Program
{
    private static void Main()
    {
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var user2 = new User("Bob", new DateTime(2023, 2, 1));
        var user3 = new User("Charlie", new DateTime(2023, 3, 1));
        var user4 = new User("David", new DateTime(2023, 4, 1));
        var user5 = new User("Eve", new DateTime(2024, 5, 1));
        var user6 = new User("Fiona", new DateTime(2024, 6, 1));
        var user7 = new User("George", new DateTime(2024, 7, 1));
        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user9 = new User("Ian");
        var user10 = new User("Julia");

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
        var book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
        var book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
        var book11 = new Book("Hamlet", new DateTime(2023, 11, 1));
        var book12 = new Book("Great Expectations", new DateTime(2023, 12, 1));
        var book13 = new Book("Ulysses", new DateTime(2024, 1, 1));
        var book14 = new Book("The Odyssey", new DateTime(2024, 2, 1));
        var book15 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
        var book16 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
        var book17 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
        var book18 = new Book("Don Quixote", new DateTime(2024, 6, 1));
        var book19 = new Book("The Iliad");
        var book20 = new Book("Anna Karenina");

        var emailService = new EmailNotificationService();
        var smsService = new SMSNotificationService();

        var libraryWithEmail = new Library(emailService);
        var libraryWithSMS = new Library(smsService);

        // Adding Books
        libraryWithEmail.AddBook(book1);
        libraryWithEmail.AddBook(book1);
        libraryWithEmail.AddBook(book2);
        libraryWithEmail.AddBook(book3);
        libraryWithEmail.AddBook(book4);

        libraryWithSMS.AddBook(book5);
        libraryWithSMS.AddBook(book6);
        libraryWithSMS.AddBook(book6);

        libraryWithEmail.AddUser(user1);
        libraryWithEmail.AddUser(user2);
        libraryWithEmail.AddUser(user3);
        libraryWithEmail.AddUser(user4);
        libraryWithEmail.AddUser(user5);

        libraryWithEmail.FindBookByTitle("The Great Gatsby");
        libraryWithEmail.FindBookByTitle("The Great Gatsy");

        libraryWithEmail.FindUserByName("Alice");
        libraryWithEmail.FindUserByName("lice");
        
        libraryWithEmail.DeleteUser(user1);
        libraryWithEmail.DeleteUser(user1);
        
        libraryWithEmail.DeleteBook(book1);
        libraryWithEmail.DeleteBook(book1);

        Console.WriteLine("\n##########################\n");
        libraryWithEmail.GetAllUsers();

        Console.WriteLine("\n##########################\n");

        libraryWithEmail.GetAllBooks();


    }
}