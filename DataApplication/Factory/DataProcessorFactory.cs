using DataApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Factory
{

    public abstract class DataProcessorFactory
    {
        public  abstract  IDataProcessor CreateDataProcessor(FileType dataType);   
    }

    public  class ConcreteDataProcessor : DataProcessorFactory
    {
        public override IDataProcessor CreateDataProcessor(FileType dataType)
        {
            switch (dataType)
            {
                case FileType.binary:
                    return  new Binary(); 
                case FileType.text:
                    return new Text();
                default:
                    return new TextReverse(); 
               
            }
        }
    }
}
