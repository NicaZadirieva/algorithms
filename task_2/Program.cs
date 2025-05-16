LinkedList<int> ints = new LinkedList<int>([1, 2, 3, 4, 5]);

// с конца до начала списка
var currentNode = ints.Last;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Previous;
}
