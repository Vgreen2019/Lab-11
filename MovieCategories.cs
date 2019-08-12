using System;
using System.Collections.Generic;

namespace Lab11
{
    internal class MovieCategories: IAnimated, IDrama, IHorror, IScifi
    {
        public void AnimatedMovies(List<Movies> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }
        
        public void DramaMovies(List<Movies> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        public void HorrorMovies(List<Movies> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        public void ScifiMovies(List<Movies> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        





    }
}