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
        public ZardosChestplate()
        
        {

        }

        public override void Effects(Player p)
        {
            p.lavaImmune = true;
            p.findTreasure = true;
            p.fireWalk = true;
            p.armorStealth = true;
            p.waterWalk = true;
            p.blockRange += 10;
            p.bulletDamage += 5f;
            p.maxMinions += 10;
            p.statLifeMax2 += 1000;
        }

        public override void DamageNPC(Player p, NPC n, int hitDir, ref int damage, ref float knockback, ref bool crit, ref float critMult)
        {
            p.statLife += 20;
        }

        public override void ArmorSetBonus(Player player) 
        {
            player.maxMinions += 10;
            player.setBonus = "Increased max number of minions";
        }
    }
}