using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviecategories = new MovieCategories();

            var categories = new List<string>();
            categories.Add("\n1. Animated");
            categories.Add("2. Drama");
            categories.Add("3. Horror");
            categories.Add("4. Sci-Fi\n");

            var animatedList = new List<Movies>();
            animatedList.Add(new Movies("The Lion King", "Animated"));
            animatedList.Add(new Movies("Angry Birds 2", "Animated\n"));
            List<Movies> SortedList = animatedList.OrderByDescending(t => t.Title).ToList();

            var dramaList = new List<Movies>();
            dramaList.Add(new Movies("Queen & Slim", "Drama"));
            dramaList.Add(new Movies("The Sun is Also a Star", "Drama\n"));

            var horrorList = new List<Movies>();
            horrorList.Sort();

            horrorList.Add(new Movies("As Above, So Below", "Horror"));
            horrorList.Add(new Movies("The Void", "Horror"));
            horrorList.Add(new Movies("It", "Horror\n"));

            var scifiList = new List<Movies>();
            scifiList.Add(new Movies("Avengers: Endgame", "Scifi"));
            scifiList.Add(new Movies("Hellboy", "Scifi"));
            scifiList.Add(new Movies("Annihilation", "Scifi\n"));

           
            Console.WriteLine("Welcome to the Movie List Application! We have tons of options to browse.");
            Console.WriteLine("Please choose a category...");

            DisplayCategoryList(categories);


            while (true)
            {
              string input = Console.ReadLine();
                DisplayMovieList(moviecategories, categories, animatedList, dramaList, horrorList, scifiList, input);

            }

        }

        private static void DisplayMovieList(MovieCategories moviecategories, List<string> categories, List<Movies> animatedList, List<Movies> dramaList, List<Movies> horrorList, List<Movies> scifiList, string input)
        {
            bool ignoreCase = true;
            if (Enum.TryParse<MovieTypes>(input, ignoreCase, out MovieTypes result))
            {
                switch (result)
                {
                    case MovieTypes.Animated:

                        moviecategories.AnimatedMovies(animatedList);
                        Console.WriteLine("\nDo you want to look at another category?  (Yes/No)");


                        while (true)
                        {
                            string input1 = Console.ReadLine();

                            if (input1 == "yes" | input1 == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("Please choose another category...");
                                DisplayCategoryList(categories);
                            }
                            else if (input1 == "no" | input1 == "No")
                            {
                                ExitApplication();
                            }
                            else
                            {
                                Console.WriteLine("This is not a valid option. Please try again...");
                                continue;

                            }
                            break;
                        }
                        break;

                    case MovieTypes.Drama:
                        moviecategories.DramaMovies(dramaList);
                        Console.WriteLine("\nDo you want to look at another category?  (Yes/No)");

                        while (true)
                        {
                            string input1 = Console.ReadLine();

                            if (input1 == "yes" | input1 == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("Please choose another category...");
                                DisplayCategoryList(categories);
                            }
                            else if (input1 == "no" | input1 == "No")
                            {
                                ExitApplication();
                            }
                            else
                            {
                                Console.WriteLine("This is not a valid option. Please try again...");
                                continue;

                            }
                            break;
                        }
                        break;

                    case MovieTypes.Horror:

                        moviecategories.HorrorMovies(horrorList);
                        Console.WriteLine("\nDo you want to look at another category?  (Yes/No)");

                        while (true)
                        {
                            string input1 = Console.ReadLine();

                            if (input1 == "yes" | input1 == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("Please choose another category...");
                                DisplayCategoryList(categories);
                            }
                            else if (input1 == "no" | input1 == "No")
                            {
                                ExitApplication();
                            }
                            else
                            {
                                Console.WriteLine("This is not a valid option. Please try again...");
                                continue;

                            }
                            break;
                        }
                        break;


                    case MovieTypes.SciFi:
                        moviecategories.ScifiMovies(scifiList);
                        Console.WriteLine("\nDo you want to look at another category?  (Yes/No)");

                        while (true)
                        {
                            string input1 = Console.ReadLine();

                            if (input1 == "yes" | input1 == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("Please choose another category...");
                                DisplayCategoryList(categories);
                            }
                            else if (input1 == "no" | input1 == "No")
                            {
                                ExitApplication();
                            }
                            else
                            {
                                Console.WriteLine("This is not a valid option. Please try again...");
                                continue;

                            }
                            break;
                        }
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("That category doesn’t exist. Try again. ");

                        DisplayCategoryList(categories);
                        break;

                }
            }
        }

        private static void DisplayCategoryList(List<string> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }
        }

        private static void ExitApplication()
        {
            Console.WriteLine("Hope you found the perfect movie! Good bye!");
            Environment.Exit(0);
        }


        public enum MovieTypes
        {
            Animated = 1,
            Drama = 2,
            Horror = 3,
            SciFi = 4

        };

    }
}
