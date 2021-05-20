using System;
using System.Collections.Generic;
using System.Text;

namespace TripCost
{
    class Trip
    {//creates public property, integer DataType, named Miles
        public int  Miles { get; set; }
        //creates public property, integer DataType, named Mpg
        public int  Mpg { get; set; }
        //creates public property, decimal DataType, named GasPrice
        public decimal GasPrice { get; set; }

        //creates public method, decimal DataType, named Cost
        public decimal Cost()
        {//returns (value of Miles * value of GasPrice) / value of Mpg
            return (Miles * GasPrice) / Mpg;
        }

    }
}
