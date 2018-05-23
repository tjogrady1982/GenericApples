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

            var coxesApples = new List<Apple> { new Apple(), new Apple(), new Apple() };
            var grannySmithApples = new List<Apple> { new Apple(), new Apple(), new Apple() };
            var pinkLadyApples = new List<Apple> { new Apple(), new Apple(), new Apple(), new Apple() };
            var braeburnApples = new List<Apple> { new Apple(), new Apple()};


            //var box = new List<Apple>();
            var firstBoxOfApples = coxesApples;
            var secondBoxOfApples = grannySmithApples;
            var thirdBoxOfApples = pinkLadyApples;
            var fourthBoxOfApples = braeburnApples;

            var cart = new List<Apple>();
            cart.AddRange(firstBoxOfApples);
            cart.AddRange(secondBoxOfApples);
            cart.AddRange(thirdBoxOfApples);
            cart.AddRange(fourthBoxOfApples);

            //{
            //    firstBoxOfApples,
            //    secondBoxOfApples,
            //    thirdBoxOfApples,
            //    fourthBoxOfApples
            //};

            var appleCounter = new Counter<Apple>();
            pinkLadyApples.ForEach(appleCounter.Add);

            Console.WriteLine(appleCounter.CountList.Count);
            

            var boxCounter = new Counter<Apple>();
            firstBoxOfApples.ForEach(boxCounter.Add);

            Console.WriteLine(boxCounter.CountList.Count);

            var cartCounter = new Counter<Apple>();
            cart.ForEach(cartCounter.Add);

            Console.WriteLine(cartCounter.CountList.Count);

            Console.ReadLine();
        }
    }
}
