using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;

namespace ParentsEvent.Customs.Generics
{
    public abstract class GenericSceneAppliance : CustomAppliance
    {
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CImmovable(),
            new CStatic()
        };

        public override bool IsNonInteractive => true;
        public override bool IsPurchasable => false;
        public override bool PreventSale => false;
    }
}