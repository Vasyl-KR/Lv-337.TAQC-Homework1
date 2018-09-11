using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml
{
    [Serializable]
    public class VIPOrder : Order
    {
        public string Description { get; set; }
    }
    [Serializable]
    public class OrderLine
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public int Amount { get; set; }

        [XmlElement("OrderedProduct")]
        public Product Product { get; set; }
    }
      
    [Serializable]
    public class Product
    {
        [XmlAttribute]
        public int ID { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }
    }


}
