using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter
{
    public class AnimalShelter
    {
        public Stack<Animal> s1 = new Stack<Animal>();
        public Stack<Animal> s2 = new Stack<Animal>();

        public void Enqueue(Animal animal)
        {
            while (s1.Count != 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(animal);

            while (s2.Count != 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            {
                while (s1.Peek().GetType() != typeof(Cat))
                {
                    s2.Push(s1.Pop());
                }
            }

            else if (pref == "dog")
            {
                while (s1.Peek().GetType() != typeof(Dog))
                {
                    s2.Push(s1.Pop());
                }
            }

            else
            {
                return null;
            }


            Animal animal = s1.Pop();
            while (s2.Count != 0)
            {
                s1.Push(s2.Pop());
            }
            return animal;

        }
    }
}

