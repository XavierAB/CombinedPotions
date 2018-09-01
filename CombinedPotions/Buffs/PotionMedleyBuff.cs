using Terraria;
using Terraria.ModLoader;

namespace CombinedPotions.Buffs
{
    public class PotionMedleyBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Potion Medley");
            Description.SetDefault("A beautifull medley of vanilla potion effects");
            Main.debuff[Type] = false;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.magicDamage *= 1.3F;
            player.meleeDamage *= 1.1F;
            player.rangedDamage *= 1.1F;
            player.minionDamage *= 1.1F;
            player.thrownDamage *= 1.1F;
            player.statDefense += 8;
            player.moveSpeed *= 1.25F;
            player.statLifeMax2 += player.statLifeMax / 5;
            player.endurance += 0.1F;
            player.meleeCrit += 10;
            player.rangedCrit += 10;
            player.magicCrit += 10;
            player.thrownCrit += 10;
            player.thorns = 0.5F;
            player.lifeRegen *= 2;
            player.manaRegen *= 2;
        }
    }
}