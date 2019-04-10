using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System = ServiceLayer.System;

namespace NUnitTestProject1
{
    class UnitTest4
    {
        //Use case 4.1
        [Test]
        public void ManageProducts()
        {
            ServiceLayer.System s1 = ServiceLayer.System.initialize("Admin", "password123");
            s1.register("Nati", "123456");
            s1.register("Ben", "123");

            s1.login("Nati", "123456");
            s1.openStore("storename", "Nati");
            s1.addMangerToStore("storename", "Ben");

            //TODO add a command for the new manager(Ben) to do

            s1.logout("Nati");

        }
    }
}
