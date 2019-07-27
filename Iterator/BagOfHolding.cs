using System.Collections;

namespace Iterator
{
    class BagOfHoldingIterator
    {
        private readonly BagOfHolding _items;
        private int _currentIndex = 0;
        
        public BagOfHoldingIterator(BagOfHolding items)
        {
            this._items = items;
        }

        public Item First()
        {
            _currentIndex = 0;
            return _items[_currentIndex] as Item;
        }
        
        public Item Next()
        {
            _currentIndex += 1;
            if (!IsDone)
                return _items[_currentIndex] as Item;
            else
                return null;
        }

        public Item CurrentItem
        {
            get { return _items[_currentIndex] as Item; }
        }
        
        public bool IsDone
        {
            get { return _currentIndex >= _items.Count; }
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

    class BagOfHolding
    {
        private readonly ArrayList _items = new ArrayList();

        public BagOfHoldingIterator CreateIterator()
        {
            return new BagOfHoldingIterator(this);
        }
        
        public int Count => _items.Count;
        
        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }
    }
}
