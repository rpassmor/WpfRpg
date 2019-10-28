using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            _locations.Add(new Location(xCoordinate, yCoordinate, name, description,
                $"R:/AdventureGame/SOSCSRPG/Engine/Images/Locations/{imageName}"));
        }
        public Location LocationAt (int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
