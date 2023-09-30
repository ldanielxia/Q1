using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter a paragraph: ");
        //string paragraph = Console.ReadLine();

        Console.WriteLine("Your paragraph is: \r\n\r\nDaniel,\r\n\r\nIt was nice talking to you. Here is the first coding question which requires problem solving and understanding of algorithms. You can solve it in any programming language of your choice. It is a pretty common coding problem, try to resolve it without googling :).\r\n\r\n- Find the longest repeated string in a given paragraph \r\nE.g.: banana, the longest is ana\r\n\r\nHave fun!\r\n\r\nCindy");
        string paragraph = "Daniel,\r\n\r\nIt was nice talking to you. Here is the first coding question which requires problem solving and understanding of algorithms. You can solve it in any programming language of your choice. It is a pretty common coding problem, try to resolve it without googling :).\r\n\r\n- Find the longest repeated string in a given paragraph \r\nE.g.: banana, the longest is ana\r\n\r\nHave fun!\r\n\r\nCindy";

        string longestRepeatedSubstring = FindLongestRepeatedSubstring(paragraph);

        Console.WriteLine($"\nThe longest repeated substring is: {longestRepeatedSubstring}");
    }

    static string FindLongestRepeatedSubstring(string str)
    {
        int n = str.Length;
        string longestSubstring = "";

        Dictionary<string, int> substringMap = new Dictionary<string, int>();

        for (int len = 1; len <= n; len++)
        {
            for (int i = 0; i <= n - len; i++)
            {
                string substring = str.Substring(i, len);

                if (substringMap.ContainsKey(substring))
                {
                    substringMap[substring]++;
                    if (substring.Length > longestSubstring.Length && substringMap[substring] > 1)
                        longestSubstring = substring;
                }
                else
                    substringMap[substring] = 1;
            }
        }

        return longestSubstring;
    }
}