using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Store
    {
        private string name;
        private Employee[] employees;
        private Product[] products = new Product[100];
        private int countProducts = 0, maxEmployees = 10, countEmployees = 0;

        public void setName( string name )
        {
            this.name = name;
        }

        public void addProduct( Product product )
        {
            if( countProducts >= 100 )
            {
                return;
            }

            this.products[countProducts++] = product;
        }

        public Product getProduct( int index )
        {
            if( index < 0 || index >= countProducts )
            {
                return null;
            }

            return products[index];
        }

        public void addEmployee( Employee employee )
        {
            if( countEmployees >= maxEmployees )
            {
                maxEmployees += 10;
                Employee[] aux = new Employee[maxEmployees];
                employees.CopyTo(aux, 0);
                employees = aux;
            }

            employees[countEmployees++] = employee;
            employee.setStoreMember(this);
        }

        public Employee[] getEmployees()
        {
            return employees;
        }

        public string getName()
        {
            return name;
        }

        public Product[] getProducts()
        {
            return products;
        }
    }
}
