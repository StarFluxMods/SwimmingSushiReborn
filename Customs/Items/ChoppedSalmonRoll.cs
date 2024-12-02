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
    public class ChoppedSalmonRoll : CustomItem
    {
        public override string UniqueNameID => "ChoppedSalmonRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChoppedSalmonRoll").AssignMaterialsByNames();
        public override int SplitCount => 3;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.PortionedSalmonRoll
        };

        public override Item SplitSubItem => GDOReferences.PortionedSalmonRoll;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Group 3"),
                gameDataObject.Prefab.GetChild("Group 2"),
                gameDataObject.Prefab.GetChild("Group 1")
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}