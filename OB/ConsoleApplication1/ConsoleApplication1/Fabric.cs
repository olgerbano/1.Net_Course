using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fabric
    {
        private Store[] stores;
        private string name;
        private int maxStores, countStores;

        public void createFabric( string name, int maxStores )
        {
            this.name = name;
            this.maxStores = maxStores;
        }

        public void addStore(Store store)
        {
            if (countStores >= maxStores)
            {
                maxStores += 10;
                Store[] aux = new Store[maxStores];
                stores.CopyTo(aux, 0);
                stores = aux;
            }

            stores[countStores++] = store;
        }

        public Store getStore( string name )
        {

            foreach( Store store in stores )
            {
                if( store.getName().Equals(name) )
                {
                    return store;
                }
            }

            return null;
        }

        public void addEmployee( Employee employee, string storeName )
        {
            Store store = getStore(storeName);
            if( store != null )
            {
                store.addEmployee(employee);
                return;
            }

            throw new ArgumentException("Departamentul nu a fost gasit");
        }

        public ProductLabel getMostExpensiveSeller( ProductType type )
        {
            double averagePriceApple = 0, averagePriceAsus = 0, averagePriceMicrosoft = 0, averagePriceDell = 0;
            int countApple = 0, countAsus = 0, countDell = 0, countMicrosoft = 0;

            foreach( Store store in stores )
            {
                foreach( Product product in store.getProducts() )
                {
                    if( product.GetType().Equals( type ) )
                    {
                        if (product.getValue("label").Equals(ProductLabel.Apple))
                        {
                            averagePriceApple += (int) product.getValue("price");
                            countApple++;
                        }
                        if(product.getValue("label").Equals(ProductLabel.Apple))
                        {
                            averagePriceAsus += (int) product.getValue("price");
                            countAsus++;
                        }
                        if (product.getValue("label").Equals(ProductLabel.Dell))
                        {
                            averagePriceDell += (int) product.getValue("price");
                            countDell++;
                        }
                        if (product.getValue("label").Equals(ProductLabel.Microsoft))
                        {
                            averagePriceMicrosoft += (int) product.getValue("price");
                            countMicrosoft++;
                        }
                    }
                }
            }

            if( countApple > 0 )
            {
                averagePriceApple /= countApple;
            }
            if( countAsus > 0 )
            {
                averagePriceAsus /= countAsus;
            }
            if( countDell > 0 )
            {
                averagePriceDell /= countDell;
            }
            if( countMicrosoft > 0 )
            {
                averagePriceMicrosoft /= countMicrosoft;
            }

            double maxPrice = averagePriceApple;
            ProductLabel winner = ProductLabel.Apple;

            if( averagePriceAsus > maxPrice )
            {
                maxPrice = averagePriceAsus;
                winner = ProductLabel.Asus;
            }
            if( averagePriceDell > maxPrice )
            {
                maxPrice = averagePriceDell;
                winner = ProductLabel.Dell;
            }
            if( averagePriceMicrosoft > maxPrice )
            {
                maxPrice = averagePriceMicrosoft;
                winner = ProductLabel.Microsoft;
            }

            return winner;
        }
    }
}
