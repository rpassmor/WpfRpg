using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; }

        public int MinimumDamage { get; }
        public int MaximumDamage { get; }

        public int RewardExperiencePoints { get; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int currentHitPoints,
            int minimumDamage, int maximumDamage,
            int rewardExeriencePoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            ImageName = $"R:/AdventureGame/SOSCSRPG/Engine/Images/Monsters/{imageName}";
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExeriencePoints;
        }

    }
}
