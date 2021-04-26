using System;

namespace MyLinkedList
{
    public class LinkedList
    {
        //private fields
        private Node head;
        private int count;

        //constructor
        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        //public properties
        public bool Empty
        {
            get
            {
                return this.count == 0;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        //Methods
        public object this[int index] //Another way to get data at a specified index - acts as an indexer
        {
            get { return this.Get(index); }
        }

        public object Add(int index, object o) //Add item at a specified index
        {
            if (index < 0) //if user uses a -ve index value
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (index > count) //if user supplies size bigger than list size
                index = count;

            Node current = this.head;

            if(this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                current.Next = new Node(o, current.Next);
            }
            count++;

            return o;
        }

        public object Add(object o) //Add to the end of the list
        {
            return this.Add(count, o);
        }

        public object Remove(int index) //Remove item at a specified index
        {
            if (index < 0) //if user uses a -ve index value
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty)
                return null;

            if (index > count) //if user supplies size bigger than list size
                index = count - 1;

            Node current = this.head;
            object result = null;

            if(index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }

            count--;

            return result;
        }

        public void Clear() //Clear the whole list
        {
            this.head = null;
            this.count = 0;
        }

        public int IndexOf(object o) //Gets the index of the item in the list, if not in list return -1
        {
            Node current = this.head;

            for (int i = 0; i < this.count; i++)
            {
                if (current.Data.Equals(o))
                    return i;

                current = current.Next;
            }
            return -1;
        }

        public bool Contains(object o) //Check if the list contains the object
        {
            return this.IndexOf(o) >= 0;
        }

        public object Get(int index) //Gets item at the specified index
        {
            if (index < 0) //check is index is -ve value
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty) //check if list is empty
                return null;

            if (index >= this.count) //check the end of the list
                index = this.count - 1;

            Node current = this.head;

            for (int i = 0; i < index; i++)
                current = current.Next;
            
            return current.Data;
        }
    }
}
