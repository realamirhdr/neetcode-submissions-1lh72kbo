public class MinStack {

     private List<int> Elements { get; set; }
     private Stack<int> _minStack;
     private int _size;

     public MinStack()
     {
         _size = 0;
         Elements = new List<int>();
         _minStack = new Stack<int>();
     }

     public void Push(int val)
     {
         Elements.Add(val);
         _size++;

         if (_minStack.Count == 0)
         {
             _minStack.Push(val);
         }
         else
         {
             _minStack.Push(Math.Min(val, _minStack.Peek()));
         }
    
     }

     public void Pop()
     {
                  if (Elements.Count > 0)
          {
              Elements.RemoveAt(_size - 1);
              _minStack.Pop();
              _size--;
          }
     }

     public int Top()
     {
         return Elements[_size - 1];
     }

     public int GetMin()
     {
         return _minStack.Peek();
     }
}
