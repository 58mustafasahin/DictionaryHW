using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHW
{
    class MyDictionary<P, I>
    {
        P[] _arrayKey;
        P[] _tempArrayKey;
        I[] _arrayValue;
        I[] _tempArrayValue;

        public MyDictionary()
        {
            _arrayKey = new P[0];
            _arrayValue = new I[0];
        }

        public void Add(P key, I value)
        {
            _tempArrayKey = _arrayKey;
            _tempArrayValue = _arrayValue;

            _arrayKey = new P[_arrayKey.Length + 1];
            _arrayValue = new I[_arrayValue.Length + 1];

            for (int i = 0; i < _tempArrayKey.Length; i++)
            {
                _arrayKey[i] = _tempArrayKey[i];

            }
            for (int i = 0; i < _tempArrayValue.Length; i++)
            {
                _arrayValue[i] = _tempArrayValue[i];
            }

            _arrayKey[_arrayKey.Length - 1] = key;
            _arrayValue[_arrayValue.Length - 1] = value;

            for (int i = 0; i < _arrayKey.Length; i++)
            {
                Console.WriteLine("Plaka : " + _arrayKey[i] + " Şehir Adı : " + _arrayValue[i]);
            }
            Console.WriteLine("");
        }
    }
}