using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class DockPanel
    {
        [XmlAttribute("LastChildFill")]
        public string LastChildFill { get; set; }
        [XmlAttribute("Grid.Column")]
        public int GridColumn { get; set; }
        [XmlAttribute("Margin")]
        public int Margin { get; set; }
        [XmlElement("TextBlock", typeof(TextBlock))] // Указываем, что в Element может быть TextBlock
        [XmlElement("Button", typeof(Button))]
        [XmlElement("ListBox", typeof(ListBox))]
        [XmlElement("CheckBox", typeof(CheckBox))]
        [XmlElement("GroupBox", typeof(GroupBox))]
        public List<object> Elements { get; set; }
    }
}
