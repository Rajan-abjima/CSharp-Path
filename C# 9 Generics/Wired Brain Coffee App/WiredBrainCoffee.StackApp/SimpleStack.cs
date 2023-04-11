namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack<T>
    {
        private readonly T[] _items;
        private int _CurrentIndex = -1;
        public SimpleStack() => _items = new T[10];
        public int count => _CurrentIndex + 1;
        public void Push(T item) => _items[++_CurrentIndex] = item;
        public T Pop() => _items[_CurrentIndex--];
    }
}