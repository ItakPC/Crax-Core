using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using TAPI;

namespace CraxCore.Items.devItems
{

    public abstract class DevItem : ModItem
    {

        protected string Developer
        {
            get;
            private set;
        }


        protected DevItem(string devName)
            : base()
        {
            Developer = devName;
        }

        public override void HoldStyle(Player p)
        {
            base.HoldStyle(p);

            PunishIfCheater(p);
        }

        public override void UseStyle(Player p)
        {
            base.UseStyle(p);

            PunishIfCheater(p);
        }

        public override bool CanUse(Player p)
        {
            PunishIfCheater(p);

            return base.CanUse(p) && IsOwner(p);
        }


        public bool IsOwner(Player p)
        {
            return
#if DEBUG
 p.name == Developer
#else
                false
#endif
;
        }

        protected void PunishIfCheater(Player p, Action<Player> fn = null)
        {
            if (IsOwner(p))
            {
                if (fn != null)
                    fn(p);

                return;
            }

            byte d = p.difficulty;
            p.difficulty = 0;

            p.KillMe(Math.Max(p.statLifeMax + 1, 9001d), 1, false, " did something " + Developer + " would not like...");

            item.SetDefaults(0);

            OnFoundCheater(p);

            p.difficulty = d;
        }

        protected virtual void OnFoundCheater(Player p) { }
    }
}
