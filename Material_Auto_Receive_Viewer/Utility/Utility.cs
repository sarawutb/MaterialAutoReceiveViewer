using System.Reflection;
using System.Text.Json.Serialization;

namespace Material_Auto_Receive_Viewer.Utility
{
    public static class Utility
    {
        public static string GetPropertyNameByPropertyNameJson(object obj, string propertyName)
        {
            var propertyInfo = obj.GetType().GetProperty(propertyName);

            if (propertyInfo == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found in type '{obj.ToString()}'.");
            }

            JsonPropertyNameAttribute attribute = (JsonPropertyNameAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(JsonPropertyNameAttribute));
            return attribute?.Name;
        }

        public static List<string> GetPropertiesNameOfClass(object pObject)
        {
            List<string> propertyList = new List<string>();
            if (pObject != null)
            {
                foreach (var prop in pObject.GetType().GetProperties())
                {
                    propertyList.Add(prop.Name);
                }
            }
            return propertyList;
        }

        public static string GetListPropertyValues<T>(object obj, string propertyName)
        {
            try
            {
                var property = obj.GetType().GetProperty(propertyName);

                if (property == null)
                {
                    throw new ArgumentException($"Property {propertyName} does not exist or is not a List.");
                }

                var value = property.GetValue(obj).ToString();
                return value;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
