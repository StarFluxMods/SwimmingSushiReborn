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
    public class SalmonWithRoe : CustomItem
    {
        public override string UniqueNameID => "SalmonWithRoe";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SalmonWithRoe").AssignMaterialsByNames();
        public override int SplitCount => 5;
        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.SalmonFillet
        };

        public override Item SplitSubItem => GDOReferences.Roe;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("SalmonWithRoe/Roe5"),
                gameDataObject.Prefab.GetChild("SalmonWithRoe/Roe4"),
                gameDataObject.Prefab.GetChild("SalmonWithRoe/Roe3"),
                gameDataObject.Prefab.GetChild("SalmonWithRoe/Roe2"),
                gameDataObject.Prefab.GetChild("SalmonWithRoe/Roe1"),
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}