namespace DataStructures.ArrayImplementation.Implementations
{
    public class ArrayImplementation
    {
        private Object[] _data;
        public int _length;
        public ArrayImplementation()
        {
            _length = 0;
            _data = new Object[1];
        }

        public Object Get(int index)
        {
            return _data[index];
        }

        public Object[] Push(Object item)
        {
            if (_data.Length == _length)
            {
                Object[] temp = new Object[_length];
                Array.Copy(_data, temp, _length);
                _data = new Object[_length + 1];
                Array.Copy(temp, _data, _length);
            }
            _data[_length] = item;
            _length++;

            return _data;
        }

        public Object Pop()
        {
            Object poped = _data[_length - 1];
            _data[_length - 1] = null;  //nulling out the last item
            _length--; //decresing the length by 1 index            
            return poped; //returning the poped array
        }

        public Object Delete(int index)
        {
            Object itemToDelete = _data[index];
            ShiftItems(index); //calling the shiftItems method to shift the items at index
            return itemToDelete;
        }

        private void ShiftItems(int index)
        {
            for (int i = index; i < _length - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            _data[_length - 1] = null;
            _length--;
        }
    }
}