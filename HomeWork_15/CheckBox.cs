using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class CheckBox
    {
        [XmlAttribute("DockPanel.Dock")]
        public string Dock { get; set; }
        [XmlAttribute("VerticalAlignment")]
        public string VerticalAlignment { get; set; }
        [XmlAttribute("HorizontalAlignment")]
        public string HorizontalAlignment { get; set; }
        [XmlAttribute("Margin")]
        public string Margin { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Checked")]
        public string Checked { get; set; }
        [XmlAttribute("Unchecked")]
        public string Unchecked { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
