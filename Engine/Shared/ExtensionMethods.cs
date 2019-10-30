using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Engine.Shared
{
    public static class ExtensionMethods
    {
        public static int AttributeAsInt(this XmlNode node, string attributeName)
        {
            return Convert.ToInt32(node.AttributeAsString(attributeName));
        }
        public static string AttributeAsString(this XmlNode node, string attributeName)
        {
            XmlAttribute attribute = node.Attributes?[attributeName];
            if (attribute == null)
            {
                throw new ArgumentException($"The attribute '{attributeName}' is empty.");
            }
            return attribute.Value;
        }
    }

}
