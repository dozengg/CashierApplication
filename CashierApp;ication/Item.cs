using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp_ication
{
    internal abstract class Item
    {
        protected int Quanaity;
        protected double Total_Price;
        protected double item_price;
        protected string item_name;

        public abstract double getTotalPrice();
        public abstract double getChange();

        public abstract void setPayment(double amount);
    }
}
