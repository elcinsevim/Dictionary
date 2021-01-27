using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{ 


    class Dictionary<T, K>
    {
        T[] _keys;
        K[] _value;

        public Dictionary()
        {
           _keys = new T[0];
            _value= new K[0];
        }


        public void Add(T key, K value)

        {
            T[] tempKey = _keys;
            _keys = new T[tempKey.Length + 1];
            K[] tempValue = _value;
            _value = new K[tempValue.Length + 1];


            for (int i = 0; i < tempKey.Length; i++)
            {
                _keys[i] = tempKey[i];
                _value[i] = tempValue[i];
            }
            _keys[_keys.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
        
        public void List()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine("İŞLEM :"+_keys[i]+", NUMARA:"+_value[i]);
            }
        }
    }
}
