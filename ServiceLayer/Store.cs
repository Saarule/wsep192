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
        private List<StoreOwner> storeOwners;

        public Store(int storeId, string storeName, StoreOwner storeOwner)
        {
            products = new List<Product>();
            buyingPolicy = new BuyingPolicy();
            purchasePolicy = new PurchasePolicy();
            salesPolicy = new SalesPolicy();
            storeOwners = new List<StoreOwner>();
            storeOwners.Add(storeOwner);
            storeID = storeId;
        }

        public string getName()
        {
            return this.name;
        }

        public List<StoreOwner> getStoreOwners()
        {
            return storeOwners;
        }

        public List<Product> getProducts()
        {
            return products;
        }
    }
}
