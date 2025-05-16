using System;

namespace GettersNSetters
{
    class Movie
    {
        // public means it can be accessed by everyone
        public string title;
        public string director;
        // public string rating;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            // The reason we need this getters and setters is b/c we made the rating entity private
            get { return rating; }
            set {
                if(value == "G"
                  || value == "PG"
                   || value == "PG-13"
                    || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else {
                    rating = "NR";
                }
            }
        }
    }
}