using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; }
        public int RewardExperiencePoints { get; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int currentHitPoints,
            int rewardExeriencePoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            ImageName = $"R:/AdventureGame/SOSCSRPG/Engine/Images/Monsters/{imageName}";
            RewardExperiencePoints = rewardExeriencePoints;
        }

    }
}
