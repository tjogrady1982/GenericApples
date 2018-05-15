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

            var firstBoxOfApples = new Box(coxesApples);
            var secondBoxOfApples = new Box(grannySmithApples);
            var thirdBoxOfApples = new Box(pinkLadyApples);
            var fourthBoxOfApples = new Box(braeburnApples);

            var cart = new List<Box>();
            cart.Add(firstBoxOfApples);
            cart.Add(secondBoxOfApples);
            cart.Add(thirdBoxOfApples);
            cart.Add(fourthBoxOfApples);

            var appleCounter = new Counter<Apple>();
            //pinkLadyApples.ForEach(appleCounter)
            //pinkLadyApples.ForEach(appleCounter.Add);

            //var boxCounter = new Counter<Box<Apple>>();
            //cartCounter.Add(cart);
        }
    }
}
