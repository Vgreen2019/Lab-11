using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    internal class MovieCategories: IAnimated, IDrama, IHorror, IScifi
    {
        public void AnimatedMovies(List<Movies> movies)
        {
            var animatedListInAscOrder = movies.OrderBy(t => t.Title);

            foreach (var movie in animatedListInAscOrder)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }
        
        public void DramaMovies(List<Movies> movies)
        {

            var dramaListInAscOrder = movies.OrderBy(t => t.Title);

            foreach (var movie in dramaListInAscOrder)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        public void HorrorMovies(List<Movies> movies)
        {
            var horrorListInAscOrder = movies.OrderBy(t => t.Title);

            foreach (var movie in horrorListInAscOrder)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        public void ScifiMovies(List<Movies> movies)
        {
            var scifiListInAscOrder = movies.OrderBy(t => t.Title);

            foreach (var movie in scifiListInAscOrder)
            {
                Console.WriteLine($"{movie.Title}");
            }
        }

        





    }
}
