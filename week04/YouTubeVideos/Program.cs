using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Learning C#";
        video1._author = "John Doe";
        video1._duration = 300; // Length in seconds

        Comment comment1 = new Comment();
        comment1._commenterName = "Alice";
        comment1._commentText = "Great video!";

        Comment comment2 = new Comment();
        comment2._commenterName = "Bob";
        comment2._commentText = "Very informative.";

        Comment comment3 = new Comment();
        comment3._commenterName = "Charlie";
        comment3._commentText = "Thanks for sharing!";

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);


        Video video2 = new Video();
        video2._title = "Advanced C# Techniques";
        video2._author = "Jane Smith";
        video2._duration = 600; // Length in seconds

        Comment comment4 = new Comment();
        comment4._commenterName = "David";
        comment4._commentText = "This helped me a lot!";

        Comment comment5 = new Comment();
        comment5._commenterName = "Eve";
        comment5._commentText = "Excellent explanation.";

        Comment comment6 = new Comment();
        comment6._commenterName = "Frank";
        comment6._commentText = "I learned something new today.";

        Comment comment7 = new Comment();
        comment7._commenterName = "Grace";
        comment7._commentText = "Can't wait to try these techniques.";

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);


        Video video3 = new Video();
        video3._title = "C# Design Patterns";
        video3._author = "Alice Johnson";
        video3._duration = 900; // Length in seconds

        Comment comment8 = new Comment();
        comment8._commenterName = "George";
        comment8._commentText = "Design patterns are essential!";

        Comment comment9 = new Comment();
        comment9._commenterName = "Hannah";
        comment9._commentText = "Great overview of patterns.";

        Comment comment10 = new Comment();
        comment10._commenterName = "Ian";
        comment10._commentText = "I love C# design patterns.";

        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        // Get the number of comments
        int numberOfComments = video1.GetNumberOfComments();
        Console.WriteLine($"Video Title: {video1._title}");
        Console.WriteLine($"Number of Comments: {numberOfComments}");

        numberOfComments = video2.GetNumberOfComments();
        Console.WriteLine($"Video Title: {video2._title}");
        Console.WriteLine($"Number of Comments: {numberOfComments}");

        numberOfComments = video3.GetNumberOfComments();
        Console.WriteLine($"Video Title: {video3._title}");
        Console.WriteLine($"Number of Comments: {numberOfComments}");

    }
}