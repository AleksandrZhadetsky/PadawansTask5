using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 1)
            {
                return "Yes";
            }
            int counter = 0;
            for (int i = 0, j = source.Length - 1; i < source.Length / 2; i++, j--)
            {
                if (source[i] == source[j])
                {
                    counter++;
                }
            }

            if (counter == source.Length / 2)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
