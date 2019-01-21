using System.Collections;

namespace Iterator_09
{
    public class MyPancakeHouseMenuIterator : IEnumerator
    {
        private readonly ArrayList _menuItems;
        private int _position = 0;

        public MyPancakeHouseMenuIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool MoveNext()
        {
            if (_position >= _menuItems.Count || _menuItems[_position] == null)
            {
                return false;
            }
            _position++;
            return true;
        }

        public void Reset()
        {
            _position = 0;
        }

        public object Current => _menuItems[_position - 1];
    }
}