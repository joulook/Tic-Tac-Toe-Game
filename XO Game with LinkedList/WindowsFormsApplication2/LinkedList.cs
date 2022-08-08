using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class LinkedList
    {
        public  int NumberOfNodes = 0;
        public class Node
        {
            int data;
            Node next;
            public Node(int data)
            {
                setData(data);
            }
            public Node()
            {

            }
            public void setData(int data)
            {
                this.data = data;
            }
            public void setNext(Node a)
            {
                next = a;
            }
            public int getData()
            {
                return data;
            }
            public Node getNext()
            {
                return next;
            }
        }
        public Node l;
        public Node middle;
        public LinkedList()
        {
            middle = new Node();
            l = middle;
            middle.setNext(null);
        }
        public bool insertInFirst(int item)
        {
            Node p = new Node(item);
            if (p == null)
                return false;

            p.setNext(l);
            l = p;
            NumberOfNodes++;
            return true;
        }
        public bool insertInLast(int item)
        {
            Node p = new Node(item);
            if (p == null)
                return false;
            Node t = middle;
            Node s = null;
            while (t != null)
            {
                s = t;
                t = t.getNext();
            }
            s.setNext(p);
            NumberOfNodes++;
            return true;
        }
        public bool delete()
        {
            if (l != middle)
            {
                l = l.getNext();
                NumberOfNodes--;
                return true;
            }
            if (middle.getNext() != null)
            {
                middle.setNext((middle.getNext()).getNext());
                NumberOfNodes--;
                return true;
            }
            return false;
        }
        public bool find(Node x,int item)
        {
            Node t = null;
            if (x == l)
            {
                t = l;
                while (t != middle && t.getData() != item)
                {
                    t = t.getNext();
                }
                return (t != middle);
            }
            else
            {
                t = middle.getNext();
                while(t!=null && t.getData() != item)
                {
                    t = t.getNext();
                }
                return (t != null);
            }
            
        }

    }
}
