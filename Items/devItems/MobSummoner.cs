using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace CraxCore.Items.devItems
{
    public class MobSummoner : DevItem
    {
        public MobSummoner()
            : base(devData.Itorius)
        {

        }

        public override bool? UseItem(Player player)
        {

            NPC.NewNPC(new Vector2(player.position.X, player.position.Y - 256), "Zombie");

            return true;
        }
    }
}
