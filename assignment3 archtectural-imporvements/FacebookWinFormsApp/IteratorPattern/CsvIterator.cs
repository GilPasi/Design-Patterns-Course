using System.Collections.Generic;
using System.IO;
using BasicFacebookFeatures.StrategyPattern;

namespace BasicFacebookFeatures.IteratorPattern
{
    public class CsvIterator<T>
    {
        public string FilePath{get; set;}
        public IParser<T> Parser { get; set; }

        public IEnumerable<T> AllItems
        {
            get
            {
                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        wasteFirstLine(reader);
                        while (!reader.EndOfStream)
                        {
                            yield return Parser.Parse(reader.ReadLine());
                        }
                    }
                }
            }
        }

        private void wasteFirstLine(StreamReader i_Reader)
        {
            if (!i_Reader.EndOfStream)
            {
                i_Reader.ReadLine();
            }
        }
    }
}
