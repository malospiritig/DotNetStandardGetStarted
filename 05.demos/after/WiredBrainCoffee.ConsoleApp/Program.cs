using System;
using WiredBrainCoffee.Simulators;

namespace WiredBrainCoffee.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var coffeeMachine = new CoffeeMachine();
      coffeeMachine.MakeCappuccino();
      coffeeMachine.MakeCappuccino();

      Console.WriteLine($"Counter cappuccino: {coffeeMachine.CounterCappuccino}");

      // Throws Exception, as WPF is not part of .NET Core
      //coffeeMachine.ShowStoredState();
    }
  }
}
