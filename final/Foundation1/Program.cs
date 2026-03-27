using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Generic Variables
        string title;
        string author;
        int length;
        int numComments;
        string commentAuthor;
        string commentText;
        int counter;

        // Lists
        List<Video> videoList = new List<Video>();
        List<Comment> commentList = new List<Comment>();

        // Video 1 Variables
        string titleOne = "Crazy Food Video";
        string authorOne = "Fred Dref";
        int lengthOne = 63;

        // Video 1 Comment Variables
        string commentAuthorOne = "Bob Bob";
        string commentTextOne = "First Post";
        string commentAuthorTwo = "Hank Kanh";
        string commentTextTwo = "This video is soooo boring. Who eats food?";
        string commentAuthorThree = "Harold Dlorah";
        string commentTextThree = "This reminds me of that one video.";
        string commentAuthorFour = "Tiffany Ynaffit";
        string commentTextFour = "I really want some McDonalds right now.";

        // Video 2 Variables
        string titleTwo = "Boring Sports Video";
        string authorTwo = "George Egroeg";
        int lengthTwo = 95;

        // Video 2 Comment Variables
        string commentAuthorFive = "Dylann Nnalyd";
        string commentTextFive = "I love sports. I hope this team wins";
        string commentTextSix = "This video is soooo interesting. Who doesn't love sports?";
        string commentAuthorSeven = "Hannah Hannah";
        string commentTextSeven = "Someday, I am going to be an astronaut. I am going to fly to the moon in a giant taco. Wait what are we talking about?";
        string commentAuthorEight = "Frank Knarf";
        string commentTextEight = "I would rather drink flourinated bathwater than watch this video.";

        // Video 3 Variables
        string titleThree = "See a Massive 60,000 Feet Long Fish! Totally Real!";
        string authorThree = "Marvin Nivram";
        int lengthThree = 39;

        // Video 3 Comment Variables
        string commentTextNine = "I love fishing. I hope this fish wins";
        string commentTextTen = "This video is soooo bland. Who fishes?";
        string commentAuthorEleven = "Megan Negam";
        string commentTextEleven = "Is it safe to fish in fast-moving water?";
        string commentAuthorTwelve = "Sandra Ardnas";
        string commentTextTwelve = "Fishing causes cancer. I saw a YouTube video about it.";

        // Video 4 Variables
        string titleFour = "Brother Gibbons Lectures For 18 Hours Straight.";
        string authorFour = "Jacob Bocaj";
        int lengthFour = 82;

        // Video 4 Comment Variables
        string commentAuthorFourteen = "Brendan Nadnerb";
        string commentTextFourteen = "Enthralling!";
        string commentAuthorFifteen = "Hunter Retnuh";
        string commentTextFifteen = "Taking a heterodiegetical perspective through the lens of external focalization, I would asservate that I voraciously gourmandize this video.";
        string commentAuthorSixteen = "Lucas Sacul";
        string commentTextSixteen = "This video reaches past the mundane to breach the resurgent heights of the magnificent.";

        // Create comments for Video 1 Object
        Video videoOne = new Video();
        videoOne.SetTitle(titleOne);
        videoOne.SetAuthor(authorOne);
        videoOne.SetLength(lengthOne);
        videoOne.CreateComment(commentAuthorOne, commentTextOne);
        videoOne.CreateComment(commentAuthorTwo, commentTextTwo);
        videoOne.CreateComment(commentAuthorThree, commentTextThree);
        videoOne.CreateComment(commentAuthorFour, commentTextFour);
        videoList.Add(videoOne);

        // Create comments for Video 2 Object
        Video videoTwo = new Video();
        videoTwo.SetTitle(titleTwo);
        videoTwo.SetAuthor(authorTwo);
        videoTwo.SetLength(lengthTwo);
        videoTwo.CreateComment(commentAuthorFive, commentTextFive);
        videoTwo.CreateComment(commentAuthorTwo, commentTextSix);
        videoTwo.CreateComment(commentAuthorSeven, commentTextSeven);
        videoTwo.CreateComment(commentAuthorEight, commentTextEight);
        videoList.Add(videoTwo);

        // Create comments for Video 3 Object
        Video videoThree = new Video();
        videoThree.SetTitle(titleThree);
        videoThree.SetAuthor(authorThree);
        videoThree.SetLength(lengthThree);
        videoThree.CreateComment(commentAuthorFive, commentTextNine);
        videoThree.CreateComment(commentAuthorTwo, commentTextTen);
        videoThree.CreateComment(commentAuthorEleven, commentTextEleven);
        videoThree.CreateComment(commentAuthorTwelve, commentTextTwelve);
        videoList.Add(videoThree);

        // Create comments for Video 4 Object
        Video videoFour = new Video();
        videoFour.SetTitle(titleFour);
        videoFour.SetAuthor(authorFour);
        videoFour.SetLength(lengthFour);
        videoFour.CreateComment(commentAuthorOne, commentTextOne);
        videoFour.CreateComment(commentAuthorFourteen, commentTextFourteen);
        videoFour.CreateComment(commentAuthorFifteen, commentTextFifteen);
        videoFour.CreateComment(commentAuthorSixteen, commentTextSixteen);
        videoList.Add(videoFour);

        counter = 1;
        foreach (Video video in videoList)
        {
            title = video.GetTitle();
            author = video.GetAuthor();
            length = video.GetLength();
            numComments = video.GetNumberComments();
            commentList = video.GetCommentList();

            Console.WriteLine($"Video {counter}");
            Console.WriteLine($"Video Title: {title}");
            Console.WriteLine($"Video Author: {author}");
            Console.WriteLine($"Video Length: {length} Seconds");
            Console.WriteLine($"Number of Comments: {numComments}");

            Console.WriteLine("");
            Console.WriteLine("---------- Comments ----------");

            foreach (Comment comment in commentList)
            {
                commentAuthor = comment.GetCommentAuthor();
                commentText = comment.GetCommentText();

                Console.WriteLine($"Comment Author: {commentAuthor}");
                Console.WriteLine($"Comment: {commentText}");
                Console.WriteLine("");   
            }
            counter = counter + 1;
        }
    }
}