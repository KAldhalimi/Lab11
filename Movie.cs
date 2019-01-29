using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11GC
{
    class Movie
    {
        #region DataMembers
        private string title;
        private string category;
        #endregion

        #region Properties
        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }
        public string Category
        {
            set
            {
                category = value;
            }
            get
            {
                return category;
            }
        }
        #endregion

       

        public Movie(string t, string c)
        {
            Title = t;
            Category = c;
        }
       

        public void PrintInfo()
        {
            Console.WriteLine("Movie: " + Title);
        }



    }
}
