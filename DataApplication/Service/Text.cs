using DataDomain;

namespace DataApplication.Service
{
    public class Text : IDataProcessor
    {
        private const string _fileName = "Text_File.txt";

        public string ProcessData()
        {
            var data = TextFileReader.ReadDataTxtFileWithUTF8Encoding(_fileName);
            return data;
        }
    }
}
