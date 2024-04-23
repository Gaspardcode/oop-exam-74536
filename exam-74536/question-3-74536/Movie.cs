using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3_74536
{
    public enum Rate {
        G, PG, PG13, R, NC_17
    };
    class Movie
    {
        private string name { get; set; }   
        private string director { get; set; }
        private Rate rating { get; set; }

        private int runningTime { get; set; }
        string GetName()
        {
            return name;
        }
        string GetDirector()
        {
            return director;
        }
        Rate GetRating()
        {
            return rating;
        }
        int GetrunningTime()
        {
            return runningTime;
        }
        void setRating(Rate rate) {
            rating = rate;
        }
        void setRunningTime(int rt)
        {
            runningTime = rt;
        }
        public Movie(string name, string director, Rate rating, int runningTime)
        {
            this.name = name;
            this.director = director;
            this.rating = rating;
            this.runningTime = runningTime;
        }

        public void toString() {
            Console.WriteLine($"My name is {name}. I was written by {director}. I am rated {rating}. I last {runningTime} minutes.");
        }

    }
}
