using System;
using System.Text;

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            string toCompress = "aaaabbccccddeefffff";

            char[] chars = toCompress.ToCharArray();
            char prevChar = new char();
            int count = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < chars.Length; i++)
            {
                if (prevChar != 0)
                {
                    if (prevChar != chars[i])
                    {
                        sb.Append(count).Append(prevChar);
                        prevChar = new char();
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                else
                {
                    prevChar = chars[i];
                    count++;
                }
            }

            sb.Append(count).Append(prevChar);

            Console.WriteLine(sb.ToString());
        }
    }
}
