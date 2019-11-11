﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeeOfficeSDK.Tools
{
    public class AkmiiCompare<T, C> : IEqualityComparer<T>
    {
        private Func<T, C> _getField;
        public AkmiiCompare(Func<T, C> getfield)
        {
            this._getField = getfield;
        }
        public bool Equals(T x, T y)
        {
            return EqualityComparer<C>.Default.Equals(_getField(x), _getField(y));
        }
        public int GetHashCode(T obj)
        {
            return EqualityComparer<C>.Default.GetHashCode(this._getField(obj));
        }
    }
}
