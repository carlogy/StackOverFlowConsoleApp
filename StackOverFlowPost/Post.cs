using System;
namespace StackOverFlowPost
{
    public class Post
    {
        public string title;
        public string description;
        public DateTime PostDate { get; set; }
        private int _votes { get; set; }

        public int UpVote()
        {
            _votes++;
            return _votes;
        }

        public int DownVote()
        {
            _votes--;
            return _votes;
        }

        public Post()

        {

            Console.Write("What is the title of your post: ");
            title = Console.ReadLine();
            Console.Write("What is the body of your post: ");
            description = Console.ReadLine();
            PostDate = DateTime.Now;

        }

        public void DisplayPost()
        {
            Console.WriteLine();
            Console.WriteLine("Post Date: " + PostDate);
            Console.WriteLine("Post Title: " + title);
            Console.WriteLine("Post Body: " + description);
            Console.WriteLine("Votes: " + _votes);
        }

    }
}

