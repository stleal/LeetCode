public class Solution {
    public string ReversePrefix(string word, char ch) {
    var index = 0;
    var found = false;
    Stack s = new Stack();
    string prefixReversed = string.Empty;

    // loop through the word and find the first occurence of ch
    // if not found, then return the word
    for (int i = 0; i < word.Length; i++)
    {
      s.Push(word[i]);
      if (word[i] == ch)
      {
        index = i;
        found = true;
        break;
      }
    }
    if (!found)
      return word;

    // loop through the stack and pop until it's empty storing the values in prefixReversed
    while (!s.IsEmpty())
    {
      prefixReversed += s.Pop();
    }

    // concatenate the remainder of the string to answer
    return prefixReversed + word.Substring(index+1, word.Length-(index+1));
    }

public class Stack
{

  public char[] data { get; set; }
  public int size { get; set; }
  public char top { get; set; }
  public int count { get; set; }

  public Stack()
  {
    size = 1;
    data = new char[size];
    count = size-1;
    top = data[count];
  }

  public void Push(char c)
  {
    if (count >= size)
      Resize();
    data[count++] = c;
    top = data[count-1];
  }

  public char Pop()
  {
    if (count > 0)
    {
      var result = data[count-1];
      data[count-1] = ' ';
      count--;
      top = count > 0 ? data[count-1] : ' ';
      return result;
    }
    else
    {
      return ' ';
    }
  }

  public char Peek()
  {
    return (top == ' ') ? ' ' : top;
  }

  public bool IsEmpty()
  {
    return (top == ' ') ? true : false;
  }

  public void Resize()
  {
    if (size <= Int32.MaxValue / 2)
    {
      size *= 2;
      char[] local = new char[size];
      for (int i = 0; i < data.Length; i++)
      {
        local[i] = data[i];
      }
      data = local;
    }
  }

  public int GetCount() => count;

}

}