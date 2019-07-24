using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class EquipmentIterator
    {
        private readonly EquipmentCollection _equipmentItems;
        private int _currentIndex = 0;
        
        public EquipmentIterator(EquipmentCollection items)
        {
            this._equipmentItems = items;
        }

        public Item First()
        {
            _currentIndex = 0;
            return _equipmentItems[_currentIndex] as Item;
        }
        
        public Item Next()
        {
            _currentIndex += 1;
            if (!IsDone)
                return _equipmentItems[_currentIndex] as Item;
            else
                return null;
        }

        public Item CurrentItem
        {
            get { return _equipmentItems[_currentIndex] as Item; }
        }
        
        public bool IsDone
        {
            get { return _currentIndex >= _equipmentItems.Count; }
        }
    }
    
    public class Item
    {
        public string Name { get; }

        public Item(string itemName)
        {
            Name = itemName;
        }
    }

    class EquipmentCollection
    {
        private readonly ArrayList _items = new ArrayList();

        public EquipmentIterator CreateIterator()
        {
            return new EquipmentIterator(this);
        }
        
        public int Count => _items.Count;
        
        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }
    }
}
