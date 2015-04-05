using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;

namespace CraxCore.Items.devItems.Armor
{
    public class ZardosChestplate : ModItem
    {
        public override void Effects(Player p)
        {
            p.maxMinions += 10;
        }
        public override void ArmorSetBonus(Player player) 
        {
            player.maxMinions += 10;
            player.setBonus = "Increased max number of minions";
        }
    }
}