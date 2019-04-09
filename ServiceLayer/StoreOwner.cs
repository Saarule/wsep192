using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class StoreOwner : User
    {
        private List<Store> stores;

        public StoreOwner(string user_name, string password) : base(user_name, password)
        {
            stores = new List<Store>();
        }

        public void addStore(Store store)
        {
            stores.Add(store);
        }

        public List<Store> getStores()
        {
            return stores;
        }

        public bool addProduct(Product p, Store store)
        {
            if (!stores.Contains(store) || store.getProducts().Contains(p))
                return false;
            store.getProducts().Add(p);
            return true;
        }

        public bool deleteProduct(Product p, Store store)
        {
            if (!stores.Contains(store) || !store.getProducts().Contains(p))
                return false;
            store.getProducts().Remove(p);
            return true;
        }

        public bool editProduct(Product p, Store store, Product newProd)
        {
            if (!stores.Contains(store) || !store.getProducts().Contains(p))
                return false;
            store.getProducts().Remove(p);
            store.getProducts().Add(newProd);
            return true;
        }

        public bool addStoreOwner(Store store, User user)
        {
            //TODO
            return true;
        }

        public void addStoreManager()
        {

        }

        public void removeStoreOwner()
        {

        }

    }
}
