using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Menu
    {
        private static void addStoreCommand( Fabric fabric )
        {
            Console.Clear();
            Console.WriteLine("Add store ======================================================================");

            Console.Write("Enter the store name: ");
            string name = Console.ReadLine();
            if( name.Equals("") )
            {
                Console.Clear();
                Console.WriteLine("Invalid name. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            if( fabric.getStore( name ) != null )
            {
                Console.Clear();
                Console.WriteLine("Store " + name + " already exists. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            Store store = new Store();
            store.setName(name);
            fabric.addStore(store);

            Console.WriteLine("Store added. Press any key to return to the main menu");
        }

        public static void addEmployeeCommand( Fabric fabric)
        {
            Console.Clear();
            Console.WriteLine("Add employee ===================================================================");

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            if( name.Equals( "" ) )
            {
                Console.Clear();
                Console.WriteLine("Invalid name. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter employee age: ");
            int age = int.Parse(Console.ReadLine());

            if( age < 18 )
            {
                Console.Clear();
                Console.WriteLine("Invalid age. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            Employee employee = new Employee();
            employee.setInfo(name, age);

            Console.Write("Enter employee store: ");
            name = Console.ReadLine();

            if (name.Equals(""))
            {
                Console.Clear();
                Console.WriteLine("Invalid name. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            if( fabric.getStore( name ) == null )
            {
                Console.Clear();
                Console.WriteLine("Store not found. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            fabric.getStore(name).addEmployee(employee);
            Console.WriteLine("Employee added. Press any key to return to the main menu");
        }

        public static void addProductCommand( Fabric fabric )
        {
            Console.Clear();
            Console.WriteLine("Add Product ====================================================================");

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            if (name.Equals(""))
            {
                Console.Clear();
                Console.WriteLine("Invalid name. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());

            if (price <= 0)
            {
                Console.Clear();
                Console.WriteLine("Invalid price. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter store name: ");
            string storeName = Console.ReadLine();

            if (name.Equals(""))
            {
                Console.Clear();
                Console.WriteLine("Invalid name. Press any key to return to the main menu");
                Console.ReadKey();
                return;
            }
        }

        public static void mainMenu( Fabric fabric )
        {
            Console.Clear();
            Console.WriteLine("Main menu ======================================================================");

            Console.WriteLine("1. Add store");
            Console.WriteLine("2. Add employee");
            Console.WriteLine("3. Add product");
            Console.WriteLine("4. List store products");
            Console.WriteLine("5. List store employees");
            Console.WriteLine("6. List product\n");

            Console.Write("Select option: ");
            char option = (char) Console.Read();

            switch (option)
            {
                case '1':
                    addStoreCommand( fabric );
                    break;
                case '2':
                    addEmployeeCommand( fabric );
                    break;
                case '3':
                    Console.WriteLine("Under construction.\nPress any key to return to the main menu");
                    Console.ReadKey();
                    addProductCommand( fabric );
                    break;
                default:
                    break;


            }

          //  mainMenu( fabric);
        }

        public static void Main()
        {
            Fabric fabric = new Fabric();

            mainMenu(fabric);
        }
    }
}
