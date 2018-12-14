using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleighRush
{
    public class User
    {
        private string name;
        private int score;

        public User(string name)
        {
            this.name = name;
            score = 0;
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

    }
}
