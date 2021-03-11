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

        public bool HasValue
        {
            get
            {
                if (Value == null)
                {
                    return false;
                }

                return true;
            }
        }
        public T Value
        {
            get
            {
                if (_value == null)
                {
                    throw new InvalidOperationException();
                }
                return _value;
            }
            set
            {
                _value = value;
            }
        }

    }
}
