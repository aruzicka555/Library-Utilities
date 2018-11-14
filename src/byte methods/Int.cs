// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

using System;

namespace Landis.Utilities.ByteMethods
{
    public class Int
        : IByteMethods<int>
    {
        public Int()
        {
        }

        //---------------------------------------------------------------------

        public ToBytesMethod<int> ToBytes
        {
            get {
                return new ToBytesMethod<int>(BitConverter.GetBytes);
            }
        }

        //---------------------------------------------------------------------

        public FromBytesMethod<int> FromBytes
        {
            get {
                return new FromBytesMethod<int>(BitConverter.ToInt32);
            }
        }
    }
}
