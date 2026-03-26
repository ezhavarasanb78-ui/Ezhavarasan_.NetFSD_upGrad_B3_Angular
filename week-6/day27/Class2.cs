using System;
using System.Collections.Generic;
using System.Text;

namespace discon
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);
    }
    public class RegularCustomerDiscount : IDiscountStrategy
    {
       public double CalculateDiscount(double amount)
        {
            return amount * 0.05;
        }
    }
    public class PremiumCustomerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.10;
        }
    }
    public class VipCustomerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.20;
        }
    }
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;
        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
        public void CalculateFinalPrice(double amount)
        {
            double discount = _discountStrategy.CalculateDiscount(amount);
            double finalPrice = amount - discount;
            Console.WriteLine("Original Amount: " + amount);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            double amount = 1000;
            DiscountCalculator regular = new DiscountCalculator(new RegularCustomerDiscount());
            regular.CalculateFinalPrice(amount);
            DiscountCalculator premium = new DiscountCalculator(new PremiumCustomerDiscount());
            premium.CalculateFinalPrice(amount);
            DiscountCalculator vip = new DiscountCalculator(new VipCustomerDiscount());
            vip.CalculateFinalPrice(amount);
            Console.ReadLine();
        }
    }

}
