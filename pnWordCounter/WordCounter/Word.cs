using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Word
    {
        string text;
        uint count;

        //public Word()
        //{

        //}

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                value.Trim();
                if (value != " ")
                    text = value;
            }
        }

        public uint Count
        {
            get { return count; }
            set { count += 1; }
        }
    }
}
