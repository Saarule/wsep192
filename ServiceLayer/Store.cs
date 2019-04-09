using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class Store
    {
        private List<Product> products;
        private BuyingPolicy buyingPolicy;
        private PurchasePolicy purchasePolicy;
        private SalesPolicy salesPolicy;
        private int storeID;
        private String name;
        public List<string> storeOwners;

        public Store(int storeId, string storeName, string storeOwnerName)
        {
            products = new List<Product>();
            buyingPolicy = new BuyingPolicy();
            purchasePolicy = new PurchasePolicy();
            salesPolicy = new SalesPolicy();
            storeOwners = new List<string>();
            storeOwners.Add(storeOwnerName);
            storeID = storeId;
        }

        public string getName()
        {
            return this.name;
        }

        public List<string> getStoreOwners()
        {
            return storeOwners;
        }
    }
}
