using NUnit.Framework;
using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview.Chapter03
{
    /// <summary>
    /// 
    /// ### 3.6 – Animal Shelter 
    /// 
    /// An animal shelter, which holds only dogs and cats, operates on a strictly "first in, first out" basis. People must adopt either the "oldest" (based on arrival time) of all animals at the shelter, or they can select whether they would prefer a dog or a cat (and will receive the oldest animal of that type). They cannot select which specific animal they would like. Create the data structures to maintain this system and implement operations such as `enqueue`, `dequeueAny`, `dequeueDog`, and `dequeueCat`. You may use the built-in `LinkedList` data structure. 
    /// 
    /// </summary>
    class Question06
    {
        abstract class Animal
        {
            public string Name { get; protected set; }

            public Animal(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }

        }

        class Cat : Animal
        {
            public Cat(string name) : base(name) { }

        }

        class Dog : Animal
        {
            public Dog(string name) : base(name) { }

        }

        class AnimalShelter
        {
            protected LinkedList<Animal> animals;

            public AnimalShelter()
            {
                animals = new();
            }

            public void Enqueue(Animal animal)
            {
                animals.AddLast(animal);
            }

            public Animal DequeueAny()
            {
                Animal animal = animals.Last.Value;
                animals.RemoveLast();
                return animal;
            }

            public Cat DequeueCat()
            {
                return Dequeue<Cat>();
            }

            public Dog DequeueDog()
            {
                return Dequeue<Dog>();
            }

            protected T Dequeue<T>() where T : Animal
            {
                LinkedListNode<Animal> linkedListNode = animals.Last;

                while (linkedListNode != null)
                {
                    if (linkedListNode.Value is T animal)
                    {
                        linkedListNode.List.Remove(animal);
                        return animal;
                    }

                    linkedListNode = linkedListNode.Previous;
                }

                return null;
            }

        }

        [TestFixture]
        class Question06Test
        {
            [Test]
            public void Question06_AnimalShelter_EnqueueAndDequeue()
            {
                AnimalShelter animalShelter = new();

                animalShelter.Enqueue(new Cat("Cat1"));
                animalShelter.Enqueue(new Dog("Dog1"));
                animalShelter.Enqueue(new Cat("Cat2"));
                animalShelter.Enqueue(new Dog("Dog2"));
                animalShelter.Enqueue(new Cat("Cat3"));
                animalShelter.Enqueue(new Dog("Dog3"));

                Assert.AreEqual("Dog3", animalShelter.DequeueAny().Name);
                Assert.AreEqual("Cat3", animalShelter.DequeueAny().Name);
                Assert.AreEqual("Cat2", animalShelter.DequeueCat().Name);
                Assert.AreEqual("Dog2", animalShelter.DequeueDog().Name);
            }

        }

    }
}

