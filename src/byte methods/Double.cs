// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

using System;

namespace Landis.Utilities.ByteMethods
{
    public class Double
        : IByteMethods<double>
    {
        public Double()
        {
        }

        //---------------------------------------------------------------------

        public ToBytesMethod<double> ToBytes
        {
            get {
                return new ToBytesMethod<double>(BitConverter.GetBytes);
            }
        }

        //---------------------------------------------------------------------

        public FromBytesMethod<double> FromBytes
        {
            get {
                return new FromBytesMethod<double>(BitConverter.ToDouble);
            }
        }
    }
}
