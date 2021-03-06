using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bluemagic;

namespace Bluemagic.Buffs.ChaosSpirit
{
	public class ChaosPressure1 : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Chaos Pressure");
			Description.SetDefault("Slowly losing life, reduces purity shield fill rate");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			longerExpertDebuff = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			BluemagicPlayer modPlayer = player.GetModPlayer<BluemagicPlayer>(mod);
			modPlayer.chaosPressure = 1;
			modPlayer.puriumShieldChargeRate -= 0.1f;
		}
	}
}
