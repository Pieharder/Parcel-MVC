using System.Collections.Generic;

namespace Parcel.Models
{
  public class Item
  {
    public int ParcelLength { get; set; }
    public int ParcelWidth { get; set; }
    public int ParcelHeight { get; set; }
    public int ParcelWeight { get; set; }
    public int ParcelVolume { get; set; }
    public string ParcelPrice { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item (int length, int width, int height, int weight)
    {
        ParcelLength = length;
        ParcelWidth = width;
        ParcelHeight = height;
        ParcelWeight = weight;
        ParcelVolume = 0;
        ParcelPrice = "";
      
      _instances.Add(this);
    }

    public void Price()
    {
      ParcelVolume = ParcelLength * ParcelWidth * ParcelHeight;
      if(ParcelVolume < 3)
      {
        ParcelPrice = "$3";
      }
      else if(ParcelVolume >= 3 && ParcelVolume <= 16)
      {
        ParcelPrice = "$7";
      }
      else
      {
        ParcelPrice = "$99.99";
      }
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}