using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class TextBlock
    {
        [XmlAttribute("DockPanel.Dock")]
        public string Dock { get; set; }
        [XmlAttribute("FontSize")]
        public int FontSize { get; set; }
        [XmlAttribute("HorizontalAlignment")]
        public string HorizontalAlignment { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
