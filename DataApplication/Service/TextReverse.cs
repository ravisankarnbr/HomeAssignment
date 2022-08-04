using DataDomain;

namespace DataApplication.Service
{
    public class TextReverse : IDataProcessor
    {
        private const string _fileName = "Text_File.txt";
        public string ProcessData()
        {
            var data = TextFileReader.ReverseReadDataWithUTF8Encoding(_fileName);
            return data;
        }
    }
}
