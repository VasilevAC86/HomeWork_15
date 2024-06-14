using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    [XmlRoot("Grid")] // Указываем, что класс соответствует корневому каталогу "Grid"
    public class Grid
    {
        [XmlAttribute("Background")] // Атрибут нашего Grid
        public string Background { get; set; }
        [XmlElement("Grid.ColumnDefinitions")]
        public ColumnDefinitions ColumnDefinitions { get; set; }
        [XmlElement("DockPanel")]
        public List<DockPanel> DockPanels { get; set; }
    }
}
