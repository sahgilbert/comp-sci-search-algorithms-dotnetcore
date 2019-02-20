using System;
using System.Collections.Generic;

namespace SimonGilbert.Blog.Algorithms
{
    public static class JumpSearch
    {
        public static int? Find(List<int> data, int value)
        {
            var length = data.Count;
            int blockSize = Convert.ToInt32(Math.Sqrt(length));
            int block = 0;

            while (block < length / blockSize)
            {
                var blockUpperLimit = Math.Min((1 + block) * blockSize, length - 1);

                if (value <= data[blockUpperLimit])
                    break;

                block++;
            }

            for (var i = block * blockSize; i < length; i++)
            {
                if (value == data[i])
                {
                    return i;
                }
            }

            return null;
        }
    }
}
