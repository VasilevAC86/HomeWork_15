using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class DataTemplate
    {
        [XmlElement("StackPanel")]
        public StackPanel StackPanel { get; set; }
    }
}
