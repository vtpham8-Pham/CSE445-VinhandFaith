using System;

namespace CSE445Project
{
    public class MovieService : IMovieService
    {
        private static Random rng = new Random();
        public string GetRecommendation(string genre)
        {
            if (string.IsNullOrEmpty(genre))
            {
                return "Please provide a genre.";
            }

            // Fixes Case Sensitivity and allows for partial matches 
            string lowerGenre = genre.ToLower();

            if (lowerGenre.Contains("action"))
            {
                string[] actionMovies = { "The Dark Knight", "Mad Max: Fury Road", "Die Hard", "Gladiator", "John Wick" };
                return actionMovies[rng.Next(actionMovies.Length)]; 
            }

            if (lowerGenre.Contains("comedy"))
            {
                string[] comedyMovies = { "Superbad", "Step Brothers", "Dumb and Dumber", "The Hangover", "Tropic Thunder" };
                return comedyMovies[rng.Next(comedyMovies.Length)];
            }

            if (lowerGenre.Contains("sci-fi") || lowerGenre.Contains("scifi"))
            {
                string[] scifiMovies = { "Inception", "Interstellar", "The Matrix", "Blade Runner 2049", "Arrival" };
                return scifiMovies[rng.Next(scifiMovies.Length)];
            }

            if (lowerGenre.Contains("horror"))
            {
                string[] horrorMovies = { "The Conjuring", "Get Out", "A Nightmare on Elm Street", "Hereditary", "It" };
                return horrorMovies[rng.Next(horrorMovies.Length)];
            }


            // If user input doesn't match any of the above genres, return a random movie from a default list
            string[] defaultMovies = { "The Matrix", "Forrest Gump", "The Godfather", "Pulp Fiction", "The Shawshank Redemption" };
            return defaultMovies[rng.Next(defaultMovies.Length)];
        }






    }
    
}