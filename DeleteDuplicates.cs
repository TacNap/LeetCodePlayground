using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class DuplicateDeleter
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode currentNode = head;
            ListNode nextNode = head.next;

            while (nextNode != null)
            {
                if (currentNode.val == nextNode.val)
                {
                    currentNode.next = nextNode.next;
                    nextNode = nextNode.next;
                }
                else
                {
                    currentNode = currentNode.next;
                    nextNode = nextNode.next;
                }
            }

            return head;
        }
    }
}
