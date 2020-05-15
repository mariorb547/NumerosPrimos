using System;    
using System.Collections.Generic;    
using System.Linq;    
using System.Web;    
namespace NumerosPrimos.Models {    
    

    public class NumberPrime {
        
         
        public int numberEntered { get; set; }
        public int numberDivider { get; set; }
        public double result { get; set; }

    }
    public class ListNumberPrime {    


        public int numberEntered {    
            get;    
            set;    
        }    

        public IList<NumberPrime> NumberPrimes { get; set; } 
    }   

 
}