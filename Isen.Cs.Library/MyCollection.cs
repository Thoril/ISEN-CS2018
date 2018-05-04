using System;

namespace Isen.Cs.Library
{
    public class MyCollection : IMyCollection
    {    
        //Tableau de persistance de la collection
        private string[] _values;

        public MyCollection()
        {
            _values= new string[0];
        }

        public void Add(string item)
        {
            InsertAt(Count,item);
        }

        public int Count => _values.Length;

        public void InsertAt(int index, string item)
        {
            if (index < 0 || index > Count) throw new IndexOutOfRangeException();      
            var tmp = new string[Count + 1];    
            for (int i = 0; i < index; i++)
                tmp[i] = _values[i];
            tmp[index] = item;
            for (int i = index+1; i < tmp.Length; i++)
                tmp[i] = _values[i-1];
            _values = tmp;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public string[] Values => _values;
    }
}

    #region getter et setters en C#  
//    public class Myclass
//    {
//        private int _myInt;
//        
//        
//        //getter et setter #C# explicite
//        public int MyInt
//        {
//            get { return _myInt;}
//            private set { _myInt = value; }
//        }
//        //getter et setter implicite
//        public string MySring { get; private set; }
//        
//    }
    #endregion
