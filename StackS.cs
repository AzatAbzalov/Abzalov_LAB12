using System.IO.Pipes;
using System.Runtime.CompilerServices;

class StackS
{
    private string[] stackArr;
    private int top;
    private StackS minStack;
    
    public StackS()
    { 
        stackArr = new string[10];
        top = -1; 
    }
    public StackS(int n ) 
    {
        stackArr = new string[n];
        top = -1;
    }

    public string Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Стек пуст");
        }
        return stackArr[top];
    }

    public void Push(string item)
    {
        top++;
        if (top >= stackArr.Length)
        {
            Array.Resize(ref stackArr, stackArr.Length+1);
        }
        stackArr[top] = item;
    }

    public string Pop() 
    {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стек пуст");
            }
            string item = stackArr[top--];
           
            if (item.Length == minStack.Peek().Length)
            {
                minStack.Pop();
            }
            return item;
     
    }
 public bool IsEmpty()
    {
        return top == -1;
    }
    public int Count()
    {
        return top + 1;
    }
    public string GetMinString(out int linenumber, out int minlenght)
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Стек пуст");
        }
        string minString = minStack.Peek();
        linenumber = -1;
        minlenght = minString.Length;

        for (int i = top; i >= 0; i--)
        {
            if (stackArr[i] == minString)
            {
                linenumber = i + 1;
                break;
            }
        }
        return minString;       
    }
    public override string ToString()
    {
        string StackStr = " ";
        for (int i = top; i >= 0; i--)
        {
            StackStr += stackArr[i] + " ";
        }
        return StackStr;
    }

}

