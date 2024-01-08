using ExemploColecoes.Models;

//pilha
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"removendo o elemento: {pilha.Pop()}" );
pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}


//fila
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
 

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"removendo o elemento: {fila.Dequeue()}" );
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}