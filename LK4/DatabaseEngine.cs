namespace LK4
{
    public class DatabaseEngine<TKey, TValue>
    {

        private readonly Dictionary<TKey, DatabaseValue> _dictionary;
        public DatabaseEngine()
        {
            this._dictionary = new Dictionary<TKey, DatabaseValue>();
        }

        public void WriteValue(TKey tk, TValue tv,  string password)
        {
            var value = new DatabaseValue( tv, password);
            _dictionary[tk] = value;
        }
        public void ReadValue(TKey tk)
        {
            Console.WriteLine("Name - "+_dictionary[tk].Value + " Password - "+ _dictionary[tk].TablePass);

        }

        public class DatabaseValue
        {
            private readonly TValue _value;
            private readonly string _tablePass;
            public TValue Value => _value;
            public string TablePass => _tablePass;
            public DatabaseValue( TValue value, string password)
            {
                this._value = value;
                this._tablePass = password;
            }
        }
    }
}