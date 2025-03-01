﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
	using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [LocDisplayName("Herbivore Lure")]
    [Weight(300)]
    [Tag("Salad", 1)]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    public partial class HerbivoreLureItem : FoodItem
    {
        public override LocString DisplayDescription    => Localizer.DoStr("Works as a lure for animals that eat plants.");
        
        public override float Calories                  => 800;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 18, Fat = 4, Protein = 6, Vitamins = 10};
		protected override int BaseShelfLife => (int)TimeUtil.HoursToSeconds(72);
    }

}
