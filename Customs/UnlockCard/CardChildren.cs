using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;

namespace ParentsEvent.Customs.UnlockCard
{
    public class CardChildren : CustomUnlockCard
    {
        public override string UniqueNameID => "CardChildren";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>
        {
            new StatusEffect
            {
                Status = (RestaurantStatus)VariousUtils.GetID( $"{Mod.MOD_GUID}.card_children")
            }
        };
        public override UnlockGroup UnlockGroup => UnlockGroup.Generic;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override List<Unlock> HardcodedBlockers => new List<Unlock>
        {
            GDOReferences.IndividualDining
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishFloristsFlowers
        };

        public override bool IsUnlockable => !Mod.IsMysteryMeatInstalled;

        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.CardChildren;
    }
}