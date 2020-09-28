using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringDemo
{
    public interface IPullMethodUpSample
    {
        int Counter { get; }
        string Title { get; set; }

        void Increment();
    }

    public class SampleBase
    {
        public int Counter { get;  set; }
        public string Title { get; set; }

    }
    public class PullMethodUpSample : SampleBase, IPullMethodUpSample
    {
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
