using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringDemo
{
    public class ExtractInterfaceSample
    {
        public int Counter { get; private set; }
        public string Title { get; set; }
        public void Increment()
        {
            Counter++;
        }
        public void Reset()
        {
            Counter = 0;
        }
    }
}
