using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; }
        public string Name { get; }
        public int Price { get; }
        public bool IsUnique { get; }

        public GameItem(int itemTypeID, string name, int price, bool isUnique = false)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            IsUnique = isUnique;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, IsUnique);
        }
    }
}
