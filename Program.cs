//Задание 1
//StackS stack = new StackS();
//string[] lines = File.ReadAllLines(@"..\..\..\test.txt");
//foreach (string line in lines)
//{
//    stack.Push(line);
//}
//Console.WriteLine("Содержимое стека:");
//Console.WriteLine(stack.ToString());

//int lineNum, minLen;
//string minString = stack.GetMinString(out lineNum, out minLen);
//Console.WriteLine("Самая короткая строка: ");
//Console.WriteLine($"Строка: {minString}, Номер: {lineNum}, Длина: {minLen}");

//Задание 1 г)
//Stack<string> stack = new Stack<string>();
//stack.Push("white");
//stack.Push("green");
//stack.Push("yellow");
//stack.Push("cyan");
//stack.Push("black");
//string shortestString = GetMinString(stack, out int lineNum, out int minLen);
//Console.WriteLine($"Самая короткая строка: {minstring}, ее номер: {lineNum}, ее длина: {minLen}");

//    static string GetMinString(Stack<string> stack, out int lineNumber, out int minLength)
//    {
//        if (stack.Count == 0)
//        {
//            throw new InvalidOperationException("Стек пуст");
//        }

//        string minString = stack.Peek();
//        lineNumber = stack.Count;
//        minLength = minString.Length;

//        foreach (string str in stack)
//        {
//            if (str.Length < minLength)
//            {
//                minstring = str;
//                minLength = str.Length;
//                lineNumber = stack.Count - 1;
//            }
//        }

//        return minstring;
//   }

//Задание 2
//string input = Console.ReadLine();
//while (input != "")
//{
//    Console.WriteLine(checker(input));
//    input = Console.ReadLine();
//}
//string checker(string str)
//{
//    StackS stack = new(str.Length);
//    StackS ind = new(str.Length);
//    for (int i = 0; i < str.Length; i++)
//    {
//        char c = str[i];
//        if (c == '(' | c == '[' | c == '{')
//        {
//            stack.Push(c.ToString());
//            ind.Push((i + 1).ToString());
//        }
//        else if (c == ')' | c == ']' | c == '}')
//        {
//            if (stack.Count() == 0)
//            {
//                return (i + 1).ToString();
//            }
//            string top = stack.Pop();
//            ind.Pop();
//            if (c == ')' & top != "(" | c == ']' & top != "[" | c == '}' & top != "{")
//                return (i + 1).ToString();
//        }
//    }
//    if (stack.Count() > 0)
//        return ind.Peek();
//    return "YES";
//}

//Задание 3
Console.WriteLine("Введите данные:");
string input = Console.ReadLine();
Queue1 queue = new();

for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];
    if (ch >= 'A' & ch <= 'Z')
        queue.Enqueue(ch.ToString());
    else if (ch == '*')
        Console.Write(queue.Dequeue() + " ");
}
Console.WriteLine();

// Пункт 2
Console.WriteLine("Введите данные:");
string input1 = Console.ReadLine();
Queue<char> queue1 = new();

for (int i = 0; i < input1.Length; i++)
{
    char ch = input1[i];
    if (ch >= 'A' & ch <= 'Z')
        queue1.Enqueue(ch);
    else if (ch == '*')
        Console.Write(queue1.Dequeue() + " ");
}
Console.WriteLine();

// Пункт 3
Queue1 queue2 = new();
string path = @"..\..\..\test.txt";
using (StreamWriter sw = new(path))
{
    sw.Write("white\ngreen\nyellow\nbrown\nblack\nred\ncyan");
}
using (StreamReader sr = new StreamReader(path))
{
    string? line;
    while ((line = sr.ReadLine()) != null)
    {
        queue2.Enqueue(line);
    }
}

int max_index = 0;
for (int i = 1; i < queue2.Count; i++)
{
    if (queue2.ElementAt(i).Length > queue2.ElementAt(max_index).Length)
        max_index = i;
}

for (int i = 0; i < max_index; i++)
{
    string item = queue2.Dequeue();
    queue2.Enqueue(item);
}

while (!queue2.IsEmpty())
    Console.WriteLine(queue2.Dequeue());