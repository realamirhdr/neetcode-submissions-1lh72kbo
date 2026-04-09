public class MinStack {

  public List<int> Elements { get; set; }
  private int _size;
  public MinStack()
  {
     Elements = new List<int>();
      _size = 0;
  }

  public void Push(int val)
  {
      Elements.Add(val);
      _size++;
  }

  public void Pop()
  {
      Elements.RemoveAt(_size - 1);
      _size--;
  }

  public int Top()
  {
      return Elements[_size - 1];
  }

  public int GetMin()
  {
      var res = Top();

      foreach (var element in Elements)
      {
          if (element < res)
          {
              res = element;
          }
      }

      return res;
  }
}
