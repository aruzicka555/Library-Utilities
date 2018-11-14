// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

using System;

namespace Landis.Utilities.ByteMethods
{
    public class UShort
        : IByteMethods<ushort>
    {
        public UShort()
        {
        }

        //---------------------------------------------------------------------

        public ToBytesMethod<ushort> ToBytes
        {
            get {
                return new ToBytesMethod<ushort>(BitConverter.GetBytes);
            }
        }

        //---------------------------------------------------------------------

        public FromBytesMethod<ushort> FromBytes
        {
            get {
                return new FromBytesMethod<ushort>(BitConverter.ToUInt16);
            }
        }
    }
}
