using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using KitchenLib.Customs;
using UnityEngine;

namespace ParentsEvent.Utilities
{
    public class RefGenerator
    {
        private static Type GetGDOType(Type type)
        {
            return type.Namespace.Contains("KitchenLib") ? type : GetGDOType(type.BaseType);
        }

        public static void GenerateGDOReferences(Assembly assembly, string file, string prefix = "", string protectionLevel = "public")
        {
            List<string> lines = new List<string>();
            Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>();
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(CustomGameDataObject).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    if (!categories.ContainsKey(GetGDOType(type).Name.Replace("Custom", "")))
                    {
                        categories.Add(GetGDOType(type).Name.Replace("Custom", ""), new List<string>());
                    }

                    categories[GetGDOType(type).Name.Replace("Custom", "")].Add($"{protectionLevel} static {GetGDOType(type).Name.Replace("Custom", "")} {prefix}{type.Name} => ({GetGDOType(type).Name.Replace("Custom", "")})GDOUtils.GetCustomGameDataObject<{type.Name}>().GameDataObject;");
                }
            }

            foreach (string category in categories.Keys)
            {
                lines.Add("#region " + category);
                foreach (string codeLine in categories[category])
                {
                    lines.Add(codeLine);
                }

                lines.Add("#endregion");
                lines.Add("");
            }

            File.WriteAllLines(file, lines.ToArray());
            Application.Quit();
        }
    }
}