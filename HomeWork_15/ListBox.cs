using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class ListBox
    {
        [XmlAttribute("Grid.ColumnSpan")]
        public int GridColumnSpan { get; set; }
        [XmlAttribute("Background")]
        public string Background { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlElement("ListBox.ItemTemplate")]
        public ItemTemplate ItemTemplate { get; set; }
    }
}
