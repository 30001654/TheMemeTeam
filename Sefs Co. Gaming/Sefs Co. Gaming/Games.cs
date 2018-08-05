using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sefs_Co.Gaming
{
    class Games
    {
        string title, rating, description, genre;
        int review;
        double price;
        bool restricted;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Review
        {
            get { return review; }
            set { review = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool Restricted
        {
            get { return restricted; }
            set { restricted = value; }
        }

        public Games(string _title, string _rating, string _description, int _review, double _price, bool _restricted)
        {
            //ensure your referncing the setter and not the property
            title = _title;
            rating = _rating;
            description = _description;
            review = _review;
            price = _price;
            restricted = _restricted;
        }


    }
}
