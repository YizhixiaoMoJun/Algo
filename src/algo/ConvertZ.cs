/*
*
输入: s = "LEETCODEISHIRING", numRows = 4
输出: "LDREOEIIECIHNTSG"
解释:

L     D     R
E   O E   I I
E C   I H   N
T     S     G

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/zigzag-conversion
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
*
*/

using System;
using System.Text;

namespace Algo
{
    public static class ConvertZ
    {
        public static string Convert(string s, int numRows)
        {
            if (s == null || s.Length <= 0 || numRows <= 1)
            {
                return s;
            }
            var builderArray = new StringBuilder[numRows];
            for (var i = 0; i < numRows; i++)
            {
                builderArray[i] = new StringBuilder();
            }
            int dir = 1;
            var index = 0;
            foreach (var schar in s)
            {
                builderArray[index].Append(schar);
                index += dir;
                if (index <= 0 || index == numRows - 1) dir = -dir;

            }
            var sumstr = new StringBuilder();
            foreach (var j in builderArray)
            {
                sumstr.Append(j);
            }
            return sumstr.ToString();

        }
    }
}