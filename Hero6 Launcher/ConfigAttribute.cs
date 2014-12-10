using System;
using System.Collections.Generic;
using System.Text;

namespace Hero6_Launcher
{
    /// <summary>
    /// Filename: ConfigAttribute.cs
    /// Author:   Per Olav Flaten
    /// </summary>
    class ConfigAttribute
    {

        public string AttributeName { get; private set; }
        public string AttributeValue { get; private set; }
        public string Description { get; private set; }

        public ConfigAttribute(string attributeName, string attributeValue, string description)
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
            this.Description = description;
        }

        public override bool Equals(object obj)
        {
            ConfigAttribute configAttribute = (ConfigAttribute)obj;
            return this.AttributeValue.Equals(configAttribute.AttributeValue);
        }

        public override string ToString()
        {
            return this.Description;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
