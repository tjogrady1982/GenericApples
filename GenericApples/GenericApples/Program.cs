using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApples
{
    class Program
    {
        static void Main(string[] args)
        {

            var coxesApples = new List<Apple> { new Apple("Cox"), new Apple("Cox"), new Apple("Cox") };
            var grannySmithApples = new List<Apple> { new Apple("Granny Smith"), new Apple("Granny Smith"), new Apple("Granny Smith") };
            var pinkLadyApples = new List<Apple> { new Apple("Pink Lady"), new Apple("Pink Lady"), new Apple("Pink Lady"), new Apple("Pink Lady") };
            var braeburnApples = new List<Apple> { new Apple("Braburn"), new Apple("Braeburn")};


            //var box = new List<Apple>();
            var firstBoxOfApples = new Box<Apple>();

            firstBoxOfApples.Add(new Apple("Cox"));
            firstBoxOfApples.Add(new Apple("Cox"));
            firstBoxOfApples.Add(new Apple("Braeburn"));

            var secondBoxOfApples = new Box<Apple>();
            secondBoxOfApples.Add(new Apple("Braeburn"));
            secondBoxOfApples.Add(new Apple("Braeburn"));


            var cart = new Cart<Apple>();
            cart.Add(firstBoxOfApples);
            cart.Add(secondBoxOfApples);
           

            var appleCounter = new Counter<Apple>();
            pinkLadyApples.ForEach(appleCounter.Add);

            Console.WriteLine(appleCounter.Count);
            

            var boxCounter = new Counter<Box<Apple>>();
            boxCounter.Add(firstBoxOfApples);

            Console.WriteLine(boxCounter.Count);

            var cartCounter = new Counter<Cart<Apple>>();
            cartCounter.Add(cart);

            Console.WriteLine(cartCounter.Count);

            var anythingCounter = new Counter<ICountable>();
            braeburnApples.ForEach(anythingCounter.Add);
            anythingCounter.Add(cart);

            Console.WriteLine(anythingCounter.Count);

            Console.ReadLine();
        }
    }
}
