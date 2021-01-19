using System;
using System.Collections.Generic;
using System.Text;

namespace Net22_Final
{
    class GenericObject<T> where T : class
    {
        private ICollection<T> Collection { get; set; }
        public bool AddItems(T[] items)
        {
            foreach(var item in items)
            {
                Collection.Add(item);
            }

            return true;
        }
    }
}
