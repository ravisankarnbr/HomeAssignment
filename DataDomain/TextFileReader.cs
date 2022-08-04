
using System.Text;


namespace DataDomain
{
    public class TextFileReader
    {
        public static string ReadDataTxtFileWithUTF8Encoding(string txtFilePath)
        {           
            int count = 7;
            string path = Path.Combine(Environment.CurrentDirectory, @"files\", txtFilePath);
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(File.OpenRead(path), Encoding.UTF8))
                {
                    char[] buffer = new char[count];
                    int n = reader.ReadBlock(buffer, 0, count);

                    char[] result = new char[n];

                    Array.Copy(buffer, result, n);

                    string res = string.Join(" ", result);
                    return res;
                }
            }
           
            return string.Empty;
        }

        public static string ReverseReadDataWithUTF8Encoding(string txtFilePath)
        {
            int count = 7;
            string path = Path.Combine(Environment.CurrentDirectory, @"files\", txtFilePath);
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(File.OpenRead(path), Encoding.UTF8))
                {
                    char[] buffer = new char[count];
                    int n = reader.ReadBlock(buffer, 0, count);

                    char[] result = new char[n];

                    Array.Copy(buffer, result, n);

                    string res = string.Join(" ", result);
                    return stringReverse(res);
                }
            }

            return string.Empty;
        }

        private static string stringReverse(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }
    }
}
