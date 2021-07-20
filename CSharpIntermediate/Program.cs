using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        static void Main(string[] args)
        {
            UsePost();
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");

                point.Move(100, 200);
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void UseParama()
        {
            Console.WriteLine(Calculator.Add(1, 2));
            Console.WriteLine(Calculator.Add(1, 2, 3, 4));
        }

        static void UseOut()
        {
            //var number = int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Convertion Failed");
        }

        static void UseIndexers()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Filipe";
            Console.WriteLine(cookie["name"]);
        }

        static void UseStopWatch()
        {
            try
            {
                var stopWatch = new StopWatch();
                stopWatch.Start();
                stopWatch.Start();
                stopWatch.Stop();

                Console.WriteLine(stopWatch.Duration);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void UsePost()
        {
            var post = new Post();
            post.UpVote();
            post.UpVote();
            Console.WriteLine(post.Rating);
        }
    }
}
