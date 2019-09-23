using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackOverflow = new Post();
            stackOverflow.MakePost("Messi", "Can Messi win the Ballon d'Or in 2020?");
            Console.WriteLine(stackOverflow.NewPost());
            stackOverflow.Votes();
        }
    }
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdTime;
        private int _upVote;
        private int _downVote;
        private int _votes;
        private string _post;

        public void MakePost(string title, string description)
        {
            _title = title;
            _description = description;
            _createdTime = DateTime.Now;
        }

        public string NewPost()
        {
            _post = $"Title: {_title} \nDescription: {_description} \nCreated: {_createdTime}" +
                $"\nUpVotes: {_upVote}, DownVotes: {_downVote}, Votes: {_votes}. \nUse 'up' and 'down' to voting!";
            return _post;
        }

        public void Votes()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if(input.ToLower() == "up")
                {
                    _votes++;
                    _upVote += 1;
                    Console.Clear();
                    Console.WriteLine(NewPost());
                }
                
                if(input.ToLower() == "down")
                {
                    _votes++;
                    _downVote += 1;
                    Console.Clear();
                    Console.WriteLine(NewPost());
                }

                if(input.ToLower() == "quit")
                {
                    Console.Clear();
                    Console.WriteLine(NewPost());
                    break;
                }
            }
        }


    }
}
