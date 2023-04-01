using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPONLV3
{
    public class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        //… code missing
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            Dataset deepCopy = (Dataset)this.MemberwiseClone();
            List<List<string>> copy = data;
            deepCopy.data = copy;
            return deepCopy;         
        }

        public string StringConcatenationUsingStringBuilder()
        {
            StringBuilder build = new StringBuilder();
           foreach(List<string> subList in data)
            {
                foreach(string item in subList)
                {
                    build.Append(item).Append(",");
                }
            }
            return build.ToString();
        }
    }

}
