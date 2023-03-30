using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK4
{
    public class DatabaseEngine<TKey, TValue>
    {
        public DatabaseEngine(){}

        public void WriteValue(Dictionary<TKey, TValue> value, TKey tk, TValue tv)
        {
            value.Add(tk, tv);
            //Console.WriteLine(value[tk]);
        }
        public void ReadValue(Dictionary<TKey, TValue> value, TKey tk)
        {
            Console.WriteLine(value[tk]);
        }

        public class DatabaseValue
        {
            private Dictionary<TKey, TValue> _value = new Dictionary<TKey, TValue>();
            public Dictionary<TKey, TValue> Value => _value;
            private string[] _tableName = new string[10];
            public string[] TableName => _tableName;
            public DatabaseValue(){}
        }
    }
}
