namespace DataStructures.HashTable.Implementations
{
    public class HashTable
    {
        private class Nodes : List<Node> { }
        private int _size;
        private Nodes[] _data;

        public HashTable(int size)
        {
            _size = size;
            _data = new Nodes[_size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % _size;
            }
            return hash;
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            if (_data[index] == null)
            {
                _data[index] = new Nodes();
            }
            _data[index].Add(new Node(key, value));
        }

        public int Get(string key)
        {
            int index = Hash(key);
            if (_data[index] == null)
            {
                return 0;
            }
            foreach (var node in _data[index])
            {
                if (node.key.Equals(key))
                {
                    return node.value;
                }
            }
            return 0;
        }

        public List<string> Keys()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] != null)
                {
                    for (int j = 0; j < _size; j++)
                    {
                        result.Add(_data[i][j].key);
                    }
                }
            }
            return result;
        }
    }
    public class Node
    {
        public string key { get; set; }
        public int value { get; set; }

        public Node(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }
}