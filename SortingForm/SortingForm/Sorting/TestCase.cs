using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingForm.Sorting
{
    public class TestCase
    {
        private List<int> _unsortedTestCase;

        public TestCase()
        {
            _unsortedTestCase = new List<int>();
        }

        public void AddToTestCase(int numToAdd)
        {
            _unsortedTestCase.Add(numToAdd);
        }

        public List<int> UnsortedTestCase
        {
            get
            {
                return new List<int>(_unsortedTestCase);

            }
            set { _unsortedTestCase = value; }
        }
    }
}
