using System;
using Xunit;
using FIFOAnimalShelter;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HappyTest()
        {
            AnimalShelter shelter = new AnimalShelter();

            Dog d1 = new Dog();
            Cat c1 = new Cat();
            Dog d2 = new Dog();
            Cat c2 = new Cat();
            Dog d3 = new Dog();
            Cat c3 = new Cat();
            Dog d4 = new Dog();
            Cat c4 = new Cat();

            shelter.Enqueue(d1);
            shelter.Enqueue(c1);
            shelter.Enqueue(d2);
            shelter.Enqueue(c2);
            shelter.Enqueue(d3);
            shelter.Enqueue(c3);
            shelter.Enqueue(d4);
            shelter.Enqueue(c4);


            Assert.Equal(d1, shelter.s1.Peek());

        }

        [Fact]
        public void ExpectedFailure()
        {
            AnimalShelter shelter = new AnimalShelter();

            Dog d1 = new Dog();
            Cat c1 = new Cat();
            Dog d2 = new Dog();
            Cat c2 = new Cat();
            Dog d3 = new Dog();
            Cat c3 = new Cat();
            Dog d4 = new Dog();
            Cat c4 = new Cat();

            shelter.Enqueue(d1);
            shelter.Enqueue(c1);
            shelter.Enqueue(d2);
            shelter.Enqueue(c2);
            shelter.Enqueue(d3);
            shelter.Enqueue(c3);
            shelter.Enqueue(d4);
            shelter.Enqueue(c4);


            Assert.NotEqual(c1, shelter.s1.Peek());

        }





        [Fact]
        public void EdgeCase()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal test = shelter.Dequeue("rat");
            Assert.Null(test); 

        }
    }
}

