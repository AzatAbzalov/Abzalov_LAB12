public class Queue1
{
    private List<string>  queue = new();
    public int Count { get { return queue.Count; } }
    public void Enqueue(string item)
    {
        queue.Add(item);
    }
    public string Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Пусто");
        string item = queue[0];
        queue.RemoveAt(0);
        return item;
    }
    public bool IsEmpty() 
    {
        return queue.Count == 0; 
    }
    public string ElementAt(int index) 
    { 
        return queue[index]; 
    }
}