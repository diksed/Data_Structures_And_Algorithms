using DataStructures.Stack;

string message = "Selam";
var stack = new ArrayStack<char>();
for (int i = 0; i < message.Length; i++)
    stack.Push(message[i]);
var n = stack.Count;
for (int i = 0; i < n; i++)
    Console.WriteLine(stack.Pop());