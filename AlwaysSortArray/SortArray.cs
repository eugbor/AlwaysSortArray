using System;
using System.CodeDom;
using System.Collections.Generic;

namespace AlwaysSortArray
{
    class SortArray
    {
        private List<int> _list;

        public List<int> List {get { return _list; } } 

        public SortArray()
        {
            _list = new List<int>();
        }

        public void Add(int value)
        {
            var index = FindIndex(value);

            if (index == _list.Count)
                _list.Add(value);
            else
                _list.Insert(index, value);
        }

        private int FindIndex(int value)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (value < _list[i])
                {
                    return i;
                }
            }

            return _list.Count;
        }
    }
}
