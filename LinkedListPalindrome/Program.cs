using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPalindrome
{
    class Program
    {
        //Write an algorithm to determine if a linkedlist is a palindrome 

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.head = new Node('r');
            Node second = new Node('a');
            Node third = new Node('d');
            Node fourth = new Node('a');
            Node fifth = new Node('r');
            
            list.head.next = second;
            list.head.next.next = third;
            list.head.next.next.next = fourth;
            list.head.next.next.next.next = fifth;
            Console.WriteLine(LinkedList.IsPalindrome(list.head)); 
        }
    }
}
