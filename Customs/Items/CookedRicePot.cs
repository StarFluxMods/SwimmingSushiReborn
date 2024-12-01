using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class CookedRicePot : CustomItem
    {
        public override string UniqueNameID => "CookedRicePot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedRicePot").AssignMaterialsByNames();
        public override int SplitCount => 3;
        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.Pot
        };

        public override Item SplitSubItem => GDOReferences.CookedRice;
        public override Item DisposesTo => GDOReferences.Pot;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Rice 3"),
                gameDataObject.Prefab.GetChild("Rice 2"),
                gameDataObject.Prefab.GetChild("Rice 1")
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}