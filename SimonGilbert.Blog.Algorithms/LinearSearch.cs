using System.Collections.Generic;

namespace SimonGilbert.Blog.Algorithms
{
    public static class LinearSearch
    {
        public static int? Find(List<int> data, int value)
        {
            for (var i = 0; i < data.Count; i++)
            {
                if (data[i] == value)
                {
                    return i;
                }
            }

            return null;
        }

        public static int? FindUsingLambda(List<int> data, int value)
        {
            int? result = data.FindIndex(x => x.Equals(value));

            return result == -1 ? (int?)null : result;
        }
    }
}
