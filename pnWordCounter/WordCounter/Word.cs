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

        public string Text
        {
            get { return text; }
        }

        public Word(string text)
        {
            this.text = text;
            count = 1;
        }

        public uint Count
        {
            get { return count; } 
            set { count += value; }
        }
    }
}
