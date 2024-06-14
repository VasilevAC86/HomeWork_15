using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_15
{
    public class ColumnDefinitions
    {
        [XmlElement("ColumnDefinition")]
        List<ColumnDefinition> columns;
        public List<ColumnDefinition> ColumnDefinitionsList { get; set; }
    }
    public class ColumnDefinition { }
}
