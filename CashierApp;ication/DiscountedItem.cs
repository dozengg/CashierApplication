﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp_ication
{
    internal class DiscountedItem : Item
    {
        private double discounted_price;
        private double item_discount;
        private double change;
        private double payment_amount;
        private int Quantity;

        public DiscountedItem(string name, double price, int quantity, double discount)
        {
            this.item_name = name;
            this.item_discount = price;
            this.Quantity = quantity;
            this.discounted_price = discount;
        }
        public override double getTotalPrice()
        {
            discounted_price = discounted_price * 0.01;
            item_discount = item_discount - (item_discount * discounted_price);
            Total_Price = item_discount * Quantity;

            return Total_Price;
        }
        public override double getChange()
        {
            change = payment_amount - Total_Price;
            return change;
        }
        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }
    }
}
