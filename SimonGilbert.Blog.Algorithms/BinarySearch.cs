using System.Collections.Generic;

namespace SimonGilbert.Blog.Algorithms
{
    public static class BinarySearch
    {
        public static int? Find(List<int> data, int value)
        {
            var low = 0;
            var high = data.Count - 1;
            var middle = (high - low) / 2;

            while (low < high)
            {
                if (data[middle] == value)
                    break;

                if (value > data[middle])
                    low = middle + 1;
                else
                    high = middle - 1;

                middle = low + ((high - low) / 2);
            }

            if (data[middle] == value)
                return middle;

            return null;
        }

        public static int? FindUsingLibraryMethod(List<int> data, int value)
        {
            data.Sort();

            return data.BinarySearch(value);
        }
    }
}
