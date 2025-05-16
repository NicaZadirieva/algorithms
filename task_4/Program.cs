LinkedList<int> ints = new LinkedList<int>([1, 2, 3, 4, 5]);

void ReverseInPlace<T>(LinkedList<T> list)
{
    if (list.Count <= 1)
        return;

    LinkedListNode<T> current = list.First;
    while (current != null)
    {
        LinkedListNode<T> next = current.Next;
        list.Remove(current);
        list.AddFirst(current); // Перемещаем текущий узел в начало
        current = next;
    }
}
ReverseInPlace(ints);

foreach (int i in ints)
{
    Console.WriteLine(i);
}
