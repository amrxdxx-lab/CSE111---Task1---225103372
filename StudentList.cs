// Name: Amr Refaat Abualyazid Eldessouki
// Student ID: 225103372

using System;

namespace Cse111Task1
{
    public class StudentList
    {
        public Student First;
        public Student Last;
        public int Count;

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

       
        public void AddFront(int id)
        {
            Student newNode = new Student(id);

            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
            Count++;
        }

       
        public void AddEnd(int id)
        {
            Student newNode = new Student(id);

            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }

        public bool Remove(int id)
        {
            if (Count == 0)
            {
                return false;
            }

            if (First.Id == id)
            {
                First = First.Next;
                Count--;
                if (Count == 0)
                {
                    Last = null;
                }
                return true;
            }

            Student current = First;
            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    current.Next = current.Next.Next;
                    Count--;
                    if (current.Next == null)
                    {
                        Last = current;
                    }
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        
        public void Reverse()
        {
            if (Count <= 1)
            {
                return;
            }

            Student prev = null;
            Student current = First;
            Last = First;

            while (current != null)
            {
                Student nextTemp = current.Next;
                current.Next = prev;
                prev = current;
                current = nextTemp;
            }

            First = prev;
        }

        
        public void Print()
        {
            Student current = First;
            while (current != null)
            {
                Console.Write(current.Id);
                if (current.Next != null)
                {
                    Console.Write(" -> ");
                }
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}