using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
public class Car
{
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    private static List<Car> _instances = new List<Car> {};
    public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }


    

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }
}