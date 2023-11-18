using System;
using System.Linq;
using DataBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var password = "1234";
            var login = "1234";
            using (var db = new Izdat())
            {
                var user = db.customers.FirstOrDefault(x => x.customer_login == login && x.customer_password == password);
                Assert.IsNotNull(user);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (var db = new Izdat())
            {
                var cipher_of_book = 1;
                var customer_id = 1;
                var quantity = 13;
                var order = new orders
                {
                    cipher_of_book = cipher_of_book,
                    customer_id = customer_id,
                    receipt_date = DateTime.Now,
                    copies_number = quantity
                };
                db.orders.Add(order);
                db.SaveChanges();

                var orders = db.orders.FirstOrDefault(x => x.cipher_of_book == cipher_of_book && x.customer_id == customer_id);
                Assert.IsNotNull(orders);
                db.orders.Remove(orders);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            var medicineName = "test";
            var contract_term = 100.0f;
            var terminated = false;
            using (var db = new Izdat())
            {
                var contracts = new contracts()
                {
                    date = DateTime.Now,
                    contract_term = contract_term,
                    terminated = terminated
                };
                db.contracts.Add(contracts);
                db.SaveChanges();

                var contract = db.contracts.FirstOrDefault(x => x.contract_term == contract_term && x.terminated == terminated);

                Assert.IsNotNull(contract);
                db.contracts.Remove(contract);
                db.SaveChanges();
            }
        }
    }
}
