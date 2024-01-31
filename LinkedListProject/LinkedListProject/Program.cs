// See https://aka.ms/new-console-template for more information
using LinkedListLibrary;

var myList = new SingleLinkedList<string>
{
    Head = new Node<string>("First")
};

var secondNode = new Node<string>("Second");
var thirdNode = new Node<string>("Third");

myList.Head.Next = secondNode;
secondNode.Next = thirdNode;

var enumerator = myList.GetEnumerator();

while (enumerator.MoveNext())
{    
    Console.WriteLine(enumerator.Current);
}
