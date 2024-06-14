using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class ItemTemplate
    {
        [XmlElement("DataTemplate")]
        public DataTemplate DataTemplate { get; set; }
    }
}
