using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinProjectBaseDev
{
    public class StringArr
    {
        string[] init = new string[0];
        int counter = 0;

        public StringArr()
        {
            this.init = new string[0];
            this.counter = 0;
        }

        public void Add(string element){
            Array.Resize(ref init, this.counter + 1); 
            init[this.counter] = element;
            this.counter++;
        }

        public string[] PackInNewArr () {
            string[] stringArr = this.init;
            string[] packed = new string[stringArr.Length];
            for (int i = 0; i < stringArr.Length; i++)
            {
                packed[i] = stringArr[i];
            }
            return (string[])packed;
        }
    }
}