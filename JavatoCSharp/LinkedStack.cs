using System;
using System.Collections.Generic;
using System.Text;

namespace JavatoCSharp
{
	public class LinkedStack : Stack
	{
	private StackNode top;

	public bool isEmpty()
	{
		return (top == null);
	}

	public void push(char item)
	{
		StackNode newNode = new StackNode();
		newNode.data = item;
		newNode.link = top;
		top = newNode;
		// System.out.println("Inserted Item : " + item);
	}

	public char pop()
	{
		if (isEmpty())
		{
			Console.WriteLine("Deleting fail! Linked Stack is empty!!");
			return (char)0;
		}
		else
		{
			char item = top.data;
			top = top.link;
			return item;
		}
	}

	public void delete()
	{
		if (isEmpty())
		{
			Console.WriteLine("Deleting fail! Linked Stack is empty!!");

		}
		else
		{
			top = top.link;
		}
	}

	public char peek()
	{
		if (isEmpty())
		{
			Console.WriteLine("Peeking fail! Linked Stack is empty!!");
			return (char)0;
		}
		else
			return top.data;
	}

	public void printStack()
	{
		if (isEmpty())
			Console.WriteLine("Linked Stack is empty!! %n %n");
		else
		{
			StackNode temp = top;
			Console.WriteLine("Linked Stack>> ");
			while (temp != null)
			{
				Console.WriteLine("\t %c \n", temp.data);
				temp = temp.link;
			}
			Console.WriteLine();
		}
	}
}
}
