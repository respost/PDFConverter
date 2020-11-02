using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDF转换器
{
    class PdfFile
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public PdfFile()
        {
        }
        public PdfFile(string _name,string _path)
        {
            this.Name = _name;
            this.Path = _path;
        }
    }
}
