using System.Collections.Generic;

namespace SimonGilbert.Blog.Data
{
    public abstract class DataSetBase
    {
        protected internal static readonly List<int> _dataSetNumbersSmall = new List<int>() { 2, 4, 6 };
        protected internal static readonly List<int> _dataSetNumbersMedium = new List<int>() { 2, 4, 6, 8 };
        protected internal static readonly List<int> _dataSetNumbersLarge;

        static DataSetBase()
        {
            _dataSetNumbersLarge = new List<int>();

            for (int i = 0; i < 1000; i++)
                _dataSetNumbersLarge.Add(i);
        }
    }
}
