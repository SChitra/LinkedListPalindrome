using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPalindrome
{
    public class Node
    {
        public char data;
        public Node next;
        public Node(char i)
        {
            data = i;
            next = null;
        }
    }
}
