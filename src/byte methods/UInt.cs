// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

using System;

namespace Landis.Utilities.ByteMethods
{
    public class UInt
        : IByteMethods<uint>
    {
        public UInt()
        {
        }

        //---------------------------------------------------------------------

        public ToBytesMethod<uint> ToBytes
        {
            get {
                return new ToBytesMethod<uint>(BitConverter.GetBytes);
            }
        }

        //---------------------------------------------------------------------

        public FromBytesMethod<uint> FromBytes
        {
            get {
                return new FromBytesMethod<uint>(BitConverter.ToUInt32);
            }
        }
    }
}
