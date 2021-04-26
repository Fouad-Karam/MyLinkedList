using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node
    {
        //private Fields
        private object data;
        private Node next;

        //Constructor
        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        //public Properties
        public object Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.data = value;
            }
        }

        public Node Next
        {
            get
            {
                return this.next;
            }

            set
            {
                this.next = value;
            }
        }
    }
}
