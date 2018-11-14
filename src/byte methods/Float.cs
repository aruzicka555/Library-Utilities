// Contributors: 
//   James Domingo, Forest Landscape Ecology Lab, UW-Madison 

using System;

namespace Landis.Utilities.ByteMethods
{
    public class Float
        : IByteMethods<float>
    {
        public Float()
        {
        }

        public ToBytesMethod<float> ToBytes
        {
            get {
                return new ToBytesMethod<float>(BitConverter.GetBytes);
            }
        }

        public FromBytesMethod<float> FromBytes
        {
            get {
                return new FromBytesMethod<float>(BitConverter.ToSingle);
            }
        }
    }
}
