using DataStructures.Queue;

var _queue = new ArrayQueue<ToDo>();
_queue.EnQueue(new ToDo()
{
    Time = 2,
    Describe = "Okula gidilecek."
});
_queue.EnQueue(new ToDo()
{
    Time = 1,
    Describe = "Yemek yenilecek."
});
_queue.EnQueue(new ToDo()
{
    Time = 3,
    Describe = "Sınava girilecek."
});
var result = _queue.DeQueue();
Console.WriteLine(result + " yapıldı.");
Console.WriteLine(_queue.Count);
foreach (var item in _queue)
{
    Console.WriteLine(item);
}