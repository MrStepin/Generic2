using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    public class Optional <T>
    {
        private T _value;
        private bool _hasValue = false;
        public bool HasValue
        {
            get
            {
                return _hasValue;
            }
        }
        public T Value
        {
            get
            {
                if (!HasValue)
                    throw new InvalidOperationException();
                return _value;
            }
            set
            {
                _value = value;
                _hasValue = true;
            }
        }

    }
}
