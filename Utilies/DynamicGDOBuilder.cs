using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushiReborn.Utilies
{
    public class DynamicGDOBuilder
    {
        public static Type CreateDynamicGDO(Type type, string name, Dictionary<(Type, string), object> propertyValues, string UniqueNameID = "")
        {
            if (!typeof(CustomGameDataObject).IsAssignableFrom(type)) return null;

            MethodInfo methodInfo = AccessTools.Method(typeof(DynamicGDOBuilder), "CreateDynamicGDO", new[] { typeof(string), typeof(Dictionary<(Type, string), object>), typeof(string) }).MakeGenericMethod(type);
            return (Type)methodInfo.Invoke(null, new object[] { name, propertyValues, UniqueNameID });
        }


        public static Type CreateDynamicGDO<T>(string name, Dictionary<(Type, string), object> propertyValues, string UniqueNameID = "") where T : CustomGameDataObject
        {
            var assemblyName = new AssemblyName("SwimmingSushiReborn.DynamicGameDataObject");
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");

            var typeBuilder = moduleBuilder.DefineType("Dynamic" + name, TypeAttributes.Public | TypeAttributes.Class, typeof(T));

            if (string.IsNullOrEmpty(UniqueNameID))
            {
                UniqueNameID = name;
            }

            RegisterObject(name + "_UniqueNameID", UniqueNameID);
            DefineGenericPropertyValue(typeBuilder, typeof(string), name, "UniqueNameID", AccessTools.Method(typeof(DynamicGDOBuilder), "GetObject").MakeGenericMethod(typeof(string)));

            foreach ((Type, string) key in propertyValues.Keys)
            {
                RegisterObject(name + "_" + key.Item2, propertyValues[key]);
                DefineGenericPropertyValue(typeBuilder, key.Item1, name, key.Item2, AccessTools.Method(typeof(DynamicGDOBuilder), "GetObject").MakeGenericMethod(key.Item1));
            }

            var generatedType = typeBuilder.CreateType();
            return generatedType;
        }

        private static void DefineGenericPropertyValue(TypeBuilder typeBuilder, Type propertyType, string name, string propertyName, MethodInfo propertyValue)
        {
            var getter = typeBuilder.DefineMethod("get_" + propertyName, MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, propertyType, Type.EmptyTypes);

            var il = getter.GetILGenerator();
            il.Emit(OpCodes.Ldstr, name + "_" + propertyName);
            il.Emit(OpCodes.Call, propertyValue);
            il.Emit(OpCodes.Ret);

            var property = typeBuilder.DefineProperty(propertyName,
                PropertyAttributes.None,
                propertyType,
                null);
            property.SetGetMethod(getter);
        }


        private static Dictionary<string, object> objectStorage = new Dictionary<string, object>();

        public static void RegisterObject(string key, object value)
        {
            if (!objectStorage.ContainsKey(key))
            {
                objectStorage.Add(key, value);
            }
        }

        public static bool TryGetObject<T>(string key, out T result)
        {
            if (objectStorage.ContainsKey(key))
            {
                result = (T)objectStorage[key];
                return true;
            }

            result = default;
            return false;
        }

        public static T GetObject<T>(string key)
        {
            if (!objectStorage.ContainsKey(key)) return default;

            if (typeof(T) == typeof(GameObject))
            {
                ((GameObject)objectStorage[key]).AssignMaterialsByNames();
            }

            return (T)objectStorage[key];
        }
    }
}