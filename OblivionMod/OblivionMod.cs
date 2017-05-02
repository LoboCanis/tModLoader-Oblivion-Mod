using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OblivionMod
{
	class OblivionMod : Mod
	{
		public OblivionMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void AddRecipes()
        {
			//This is a test run for adding a new recipe.
			//This will take 10 dirt and stone at a workbench, and produce the Solar Pickaxe. Hopefully.
			ModRecipe dirttopick = new ModRecipe(this);
            dirttopick.AddIngredient(ItemID.DirtBlock, 10);
			dirttopick.AddIngredient(ItemID.StoneBlock, 10);
            dirttopick.AddTile(TileID.WorkBenches);
            dirttopick.SetResult(ItemID.DirtBlock, 20);
            dirttopick.AddRecipe();
        }
	}
}
