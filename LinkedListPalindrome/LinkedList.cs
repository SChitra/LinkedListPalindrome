using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPalindrome
{
    public class LinkedList
    {
        public Node head;

        public static bool IsPalindrome(Node head)
        {
            //Since we do not the size of the LinkedList we can use the slow fast pointer technique
            Node slow = head;
            Node fast = head;
            Stack<char> stack = new Stack<char>();
            while(fast != null && fast.next != null)
            {
                //Push first half of Linked list onto the stack until fast pointer reaches the end.When fast pointer reaches end slow pointer would have reached middle element.
                stack.Push(slow.data);
                slow = slow.next;
                fast = fast.next.next;
            }
            //If it has odd number of data then skip the middle data
            if(fast != null)
            {
                slow = slow.next;
            }

            while(slow != null)
            {
                int top = stack.Pop();
                //if the popped values are different then it's not a palindrome
                if (top != slow.data)
                {
                    return false;
                }
                slow = slow.next;
            }
            
            return true;
        }
    }
}
