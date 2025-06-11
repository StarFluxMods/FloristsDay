using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;

namespace ParentsEvent.Customs.UnlockCard
{
    public class CardFlowerWiltering : CustomUnlockCard
    {
        public override string UniqueNameID => "CardFlowerWiltering";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>
        {
            new StatusEffect
            {
                Status = (RestaurantStatus)VariousUtils.GetID( $"{Mod.MOD_GUID}.card_flowers_wilter")
            }
        };
        public override UnlockGroup UnlockGroup => UnlockGroup.Generic;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.LargeDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishFloristsFlowers
        };

        public override bool IsUnlockable => true;

        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.CardFlowerWiltering;
    }
}