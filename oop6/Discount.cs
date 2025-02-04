using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace oop6
{
    public abstract class Discount
    {
        public abstract decimal CalculateDiscount(decimal price, int quantity);

        public string Name { get; protected set; }

    }
    public  class PercentageDiscount : Discount
    {
        public decimal Percentage { get; }

        public PercentageDiscount(decimal percentage)
        {
            Name = "Percentage Discount";
            Percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }

    }
    public class FlatDiscount : Discount
    {
        public decimal FlatAmount { get; set; }
        public FlatDiscount(decimal flatAmount)
        {
            Name = "Flat Discount";
            FlatAmount = flatAmount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }
    public class BuyOneGetOneDiscount : Discount
    {
        public decimal FlatAmount { get; set; }
        public BuyOneGetOneDiscount()
        {
            Name = "BuyOneGetOneDiscount";
  
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
            {
                return ((price / 2) * (quantity / 2));
            } 
            return 0;
        }
    }
    public abstract class User
    {
        public string Name { get; protected set; }

        public abstract Discount GetDiscount();
    }

    public class RegularUser : User
    {
        public RegularUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

    public class PremiumUser : User
    {
        public PremiumUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

    public class GuestUser : User
    {
        public GuestUser()
        {
            Name = "Guest";
        }

        public override Discount GetDiscount()
        {
            return null;
        }
    }


}
