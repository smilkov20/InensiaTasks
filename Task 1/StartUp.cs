namespace Task_1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.Write("Input.txt file path : ");
            var path = Console.ReadLine();

            var jsonText = File.ReadAllText(path);
            var movieStars = JsonConvert.DeserializeObject<IList<MovieStar>>(jsonText);

            foreach (var movieStar in movieStars)
            {
                Console.WriteLine(movieStar.ToString());
            }
        }
    }
}
