using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubTest1
{
    class Repos
    {
        public int Counter { get; set; }
        public string textString;
        

        public Repos()
        {
            Counter = 0;
            textString = "Hello world!";

        }

        public void counterUp()
        {
            Counter++;
        }
    }
}
