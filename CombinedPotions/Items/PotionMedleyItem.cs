using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedPotions.Items
{
	public class PotionMedley : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Potion Medley");
			Tooltip.SetDefault("A beautifull medley of vanilla potions.");
		}
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
            item.useTime = 17;
            item.useAnimation = 17;
			item.useStyle = 2;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.UseSound = SoundID.Item3;
            item.buffType = item.buffType = mod.BuffType("PotionMedleyBuff");
            item.buffTime = 52000;
            item.maxStack = 30;
            item.rare = 10;
            item.consumable = true;
            item.useTurn = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
