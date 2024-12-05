﻿using KitchenData;
using KitchenLib.Customs;
using SwimmingSushiReborn.Utilies;

namespace SwimmingSushiReborn.Customs.Generic
{
    public abstract class GenericPlatedDish : CustomItemGroup
    {
        public override Item DisposesTo => GDOReferences.Plate;
        public override Item DirtiesTo => GDOReferences.PlateDirty;
        public override bool CanContainSide => true;
    }
}