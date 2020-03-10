using System.Collections.Generic;

namespace Parcel.Models
{
  public class Item
  {
    public int ParcelLength { get; set; }
    public int ParcelWidth { get; set; }
    private static List<Item> _instances = new List<Item> {};

    public Item (int length, int width)
    {
        ParcelLength = length;
        ParcelWidth = width;
      
      _instances.Add(this);
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