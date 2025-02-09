﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;

    [RequiresSkill(typeof(ButcherySkill), 1)] 
    public partial class ButcherSheepRecipe :
        RecipeFamily
    {
        public ButcherSheepRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ButcherSheep",
                    Localizer.DoStr("Butcher Sheep"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(SheepItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<RawMeatItem>(5), 
               new CraftingElement<LeatherHideItem>(1), 
               new CraftingElement<ShornWoolItem>(2),  
    
                    })
            };
            this.ExperienceOnCraft = 4;  
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ButcherSheepRecipe), 1.5f, typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Butcher Sheep"), typeof(ButcherSheepRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(ButcheryTableObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(ButcherySkill), 1)] 
    public partial class ButcherSheepElectricRecipe :
        RecipeFamily
    {
        public ButcherSheepElectricRecipe() {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ButcherSheep",
                    Localizer.DoStr("Butcher Sheep"),
                    new IngredientElement[]
                    {
            new IngredientElement(typeof(SheepItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
            new CraftingElement<RawMeatItem>(5), 
            new CraftingElement<LeatherHideItem>(1), 
            new CraftingElement<ShornWoolItem>(2),  
    
                    })
            };
            this.ExperienceOnCraft = 4;  
            this.LaborInCalories = CreateLaborInCaloriesValue(25, typeof(ButcherySkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ButcherSheepRecipe), 0.75f, typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Butcher Sheep"), typeof(ButcherSheepRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(ElectricButcheryTableObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

}
