using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace add_substract_multiply
{
    public class calculate
    {
        int num1;
        int num2;
        
        public int addition(int num1,int num2)
            {
               int add=num1+num2;
                 return add;
            }
        public int substract(int num1,int num2) 
        {
            int substraction=num1-num2;
            return substraction;
        }
        public int multiply(int num1,int num2) 
        {
            int multiplication=num1*num2;
            return multiplication;
        }
        
        
        

    }
}
