using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class CookedRicePot : CustomItem
    {
        public override string UniqueNameID => "CookedRicePot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedRicePot").AssignMaterialsByNames();
        public override int SplitCount => 3;
        public override List<Item> SplitDepletedItems => new List<Item>
        {
            (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot)
        };
        public override Item SplitSubItem => (Item)GDOUtils.GetCustomGameDataObject<CookedRice>().GameDataObject;

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