using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingYourOwnClasses
{
    //solution explore -> rigt click -> add -> class
     class Class1
    {
        // have data , methods, constructors

        private string title;
        private string description;
        private int pages;
       // private int wordCount;

        public Class1(string title, string description, int pages)
        {
            this.title = title;
            this.description = description;
            this.pages = pages;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        
    }
}
