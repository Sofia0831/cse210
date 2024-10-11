using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        videos.Add(new Video("Watch Me Absolutely Fail the QTEs (The Quarry Gameplay Part 1)", "puddinheadgaming", 3600));
        videos.Add(new Video("Rating Pokemon Characters For Fun", "JadjMasters", 1950));
        videos.Add(new Video("Trying To Bake a Cake with Havenhel", "Alinathebeloved", 2400));

        videos[0].AddComment(new Comment("jazzyj", "ijbol ryan is so funny"));
        videos[0].AddComment(new Comment("mikocappuccino", "'swarm of bears? herd of bears' 'yeah ive heard of bears' PLS??"));
        videos[0].AddComment(new Comment("ciaraKins", "The dialogue in this game is so awkward its perfect"));
        videos[0].AddComment(new Comment("Rosaliawins", "pls they did ryan so dirty with those freeze frames lmaooo"));

        videos[1].AddComment(new Comment("philoSofia", "How is N not even a 10?? blasphemy /hj"));
        videos[1].AddComment(new Comment("ShawnTheSheep", "this is very subjective AND VERY WRONG"));
        videos[1].AddComment(new Comment("yuitheGreat", "Steven deserves better than this smh"));

        videos[2].AddComment(new Comment("Raerae", "lmaooooo haven be carrying all the braincells in this duo"));
        videos[2].AddComment(new Comment("eratobloom", "Alina did pretty okay for her first time baking :D"));
        videos[2].AddComment(new Comment("Cornucopia", "erato please don't lie on her behalf"));
        videos[2].AddComment(new Comment("Alinathebeloved", "GUYS STOP OK I TRIED T_T"));
        videos[2].AddComment(new Comment("Havenhell", "never doing this again btw dont want all that stress ever again <3<3"));
        videos[2].AddComment(new Comment("Alinathebeloved", "Haven :(("));

        Console.WriteLine();
        foreach (var video in videos)
        {
            Console.WriteLine("Video Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.CountComment());
            Console.WriteLine();
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommentName() + ": " + comment.GetCommentText());
            }
            Console.WriteLine();
        }
    }
}