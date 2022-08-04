using System;
using System.Diagnostics;
using System.IO;


namespace DataDomain
{
    public class BinaryFileReader
    {
        public static string ReadBytesFromFile(string txtFilePath)
        {
            byte[] buffer = new byte[5];
            string result = string.Empty;
            try
            {
                string path = Path.Combine(Environment.CurrentDirectory, @"files\", txtFilePath);
                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        var bytes_read = fs.Read(buffer, 0, buffer.Length);
                       

                        if (bytes_read != buffer.Length)
                        {

                        }

                        result = System.Text.Encoding.UTF8.GetString(buffer); ;
                        fs.Close();
                    }
                }
                return result;
            }
            catch (System.UnauthorizedAccessException ex)
            {
                Debug.Print(ex.Message);
            }
            return result;
        }
    }
}
