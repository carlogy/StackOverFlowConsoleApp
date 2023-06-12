namespace StackOverFlowPost;
class Program
{
    static void Main(string[] args)
    {
        var FirstPost = new Post();
        

        FirstPost.UpVote();
        FirstPost.UpVote();
        FirstPost.UpVote();
        FirstPost.DownVote();

        FirstPost.DisplayPost();
        Console.ReadLine();
 
     }
}

