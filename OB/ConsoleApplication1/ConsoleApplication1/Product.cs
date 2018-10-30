using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Product
    {
        private string name;
        private ProductType type;
        private ProductLabel label;
        private int price;

        public void setInfo( string name, ProductType type, ProductLabel label, int price )
        {
            this.name = name;
            this.type = type;
            this.label = label;
            this.price = price;
        }

        public void getInfo( out string name, out ProductType type, out ProductLabel label, out int price )
        {
            name = this.name;
            type = this.type;
            label = this.label;
            price = this.price;
        }

        public void info( ref string employeeInfo )
        {
            employeeInfo = employeeInfo + name + " " + type + " " + label + " " + price;
        }

        public object getValue( string field )
        {
            switch(field)
            {
                case "name":
                    return name;
                case "type":
                    return type;
                case "label":
                    return label;
                case "price":
                    return price;
                default:
                    return null;
            }

        }
    }
}
