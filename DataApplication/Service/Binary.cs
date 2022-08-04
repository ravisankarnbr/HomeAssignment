using DataDomain;

namespace DataApplication.Service
{
    public class Binary : IDataProcessor
    {
        private const string _fileName = "Binary_File.txt";
        
        public string ProcessData()
        {
            var data = BinaryFileReader.ReadBytesFromFile(_fileName);
            return data;
        }
    }
}
