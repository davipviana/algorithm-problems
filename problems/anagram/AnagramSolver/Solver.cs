using System;

namespace AnagramSolver
{
    public static class Solver
    {
        public static bool IsAnagram(char[] firstWord, char[] secondWord)
        {
            var isAnagram = true;
            if (firstWord.Length != secondWord.Length)
                isAnagram = false;

            var secondWordForTest = new char[secondWord.Length];
            Array.Copy(secondWord, secondWordForTest, secondWord.Length);

            var pos1 = 0;
            while (pos1 < firstWord.Length && isAnagram)
            {
                var pos2 = 0;
                var found = false;
                while (pos2 < secondWordForTest.Length && !found)
                {
                    if (firstWord[pos1] == secondWordForTest[pos2])
                        found = true;
                    else
                        pos2++;
                }

                if (found)
                    ArrayRemoveAt(ref secondWordForTest, pos2);
                else
                    isAnagram = false;

                pos1++;
            }
            return isAnagram;
        }

        private static void ArrayRemoveAt<T>(ref T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                arr[a] = arr[a + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
    }
}
