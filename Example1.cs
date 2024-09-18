using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IGeneralOperation
    {
        void Add();

        void Delete();
    }

    public interface IQuantityOperation
    {
        public string Plus(int x);
    }

    public abstract class BaseOperation : IGeneralOperation
    {
        public void Add()
        {
            Console.WriteLine("Value added.");
        }

        public void Delete()
        {
            Console.WriteLine("Value deleted.");
        }
    }

    public class Customer : BaseOperation
    {

    }

    public class Product : BaseOperation, IQuantityOperation
    {
        public string Plus(int x)
        {
            var l_value = 0;
            l_value = x+1;
            return "Yeni deger: "+l_value;
        }

    }
}