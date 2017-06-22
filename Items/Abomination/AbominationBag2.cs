using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bluemagic.Items.Abomination
{
	public class AbominationBag2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 11;
			item.expert = true;
			bossBagNPC = mod.NPCType("Abomination");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			if (Main.rand.Next(7) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("AbominationMask"));
			}
			player.QuickSpawnItem(mod.ItemType("MoltenDrill"));
			player.QuickSpawnItem(mod.ItemType("DimensionalChest"));
			player.QuickSpawnItem(mod.ItemType("MoltenBar"), 5);
			player.QuickSpawnItem(mod.ItemType("SixColorShield"));
			player.QuickSpawnItem(mod.ItemType("ElementalEye"));
		}
	}
}