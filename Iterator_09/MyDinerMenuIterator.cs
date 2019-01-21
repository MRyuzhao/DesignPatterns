using System.Collections;

namespace Iterator_09
{
    public class MyDinerMenuIterator : IEnumerator
    {
        private readonly MenuItem[] _menuItems;
        private int _position = 0;

        public MyDinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool MoveNext()
        {
            if (_menuItems[_position] == null || _position >= _menuItems.Length)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            _position =0;
        }

        public object Current => _menuItems[_position-1];
    }
}