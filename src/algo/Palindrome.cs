namespace Algo
{
    public static class Palindrome
    {
        //121
        //112211

        public static bool IsPalindrom(int x)
        {
            if (x < 0)
            {
                return false;
            }
            var sum = 0;
            var x1 = x;
            while (x / 10 > 0)
            {
                var y = x % 10;
                x = x / 10;
                sum = (sum + y) * 10;
            }
            return sum + x == x1;

        }

    }
}