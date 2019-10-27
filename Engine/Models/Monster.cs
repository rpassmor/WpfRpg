using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; set; }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public int RewardExperiencePoints { get; set; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int hitPoints,
            int minimumDamage, int maximumDamage,
            int rewardExeriencePoints, int rewardGold)
        {
            Name = name;
            ImageName = $"R:/AdventureGame/SOSCSRPG/Engine/Images/Monsters/{imageName}";
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExeriencePoints;
            Gold = rewardGold;
        }

    }
}
