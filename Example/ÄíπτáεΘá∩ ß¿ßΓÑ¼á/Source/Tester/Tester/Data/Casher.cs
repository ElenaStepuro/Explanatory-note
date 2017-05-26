using System;
using System.IO;
using Newtonsoft.Json;

namespace Tester.Data
{
    public static class Casher
    {
        public static void Save(Object parObject)
        {
            String body = JsonConvert.SerializeObject(parObject);
            String path = GetPath(parObject.GetType());
            File.WriteAllText(path, body);
        }

        public static bool Exists(Type parType)
        {
            String path = GetPath(parType);
            return File.Exists(path);
        }

        public static Object Load(Type parType)
        {
            String path = GetPath(parType);
            String body = File.ReadAllText(path);

            Object result = JsonConvert.DeserializeObject(body, parType);
            return result;
        }

        private static String GetPath(Type parType)
        {
            return parType.Name + ".sqlite";
        }

    }
}
