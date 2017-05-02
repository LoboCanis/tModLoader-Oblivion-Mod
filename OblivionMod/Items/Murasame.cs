using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace OblivionMod.Items
{
	public class Murasame : ModItem
	{
		public override void SetDefaults()
		{
			//This is a test run for using a mod item.
			//In this case, it will be based off of your extremely long katana.
			item.name = "Murasame";
			item.damage = 170;
			item.melee = true;
			item.width = 100; //Dude, you made it HUGE.
			item.height = 100;
			item.toolTip = "Placeholder text.";
			item.useTime = 13; //Slight faster than Muramasa.
			item.useAnimation = 13; 
			item.useStyle = 1; //Swinging animation.
			item.knockBack = 6; //Average knockback.
			item.value = 350000; //About 35 Gold Coins.
			item.rare = 10; //Red
			item.UseSound = SoundID.Item20; //Flamelash
			item.autoReuse = true;
		}

		//public override void AddRecipes()
		//{
			//This is a test run for adding a new recipe for a mod item.
			//This will also take dirt, to make the "Murasame".
			//ModRecipe proto = new ModRecipe(this);
			//proto.AddIngredient(ItemID.DirtBlock);
			//proto.AddTile(TileID.WorkBenches);
			//proto.SetResult(this.GetItem("Murasame"));
			//proto.AddRecipe();
		//}

		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			texture = "OblivionMod/Items/Murasame";
			return true;
		}
	}
}
