﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    

    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node currentNode = this.head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }

        public void AppendNode(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node currentNode = this.head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }

        public void PrintList()
        {
            Node currentNode = this.head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + "->");
                currentNode = currentNode.next;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new linked list
            LinkedList linkedList = new LinkedList();

            // Add nodes to the linked list
            linkedList.AddNode(56);
            linkedList.AppendNode(30);
            linkedList.AppendNode(70);

            // Print the linked list
            linkedList.PrintList();
        }
    }
}*/
