using DevEngine.Core;
using DevEngine.Core.Property;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DevEngine.RealTypes.Property
{
    public class DevProperty : IDevProperty
    {
        public DevProperty( RealTypesProviderService realTypesProviderService, PropertyInfo propertyInfo)
        {
            PropertyType = realTypesProviderService.GetDevType(propertyInfo.PropertyType);
            Name = propertyInfo.Name;
            GetVisibility = propertyInfo.CanRead ? Visibility.Public : Visibility.None;
            SetVisibility = propertyInfo.CanWrite ? Visibility.Public : Visibility.None;
        }

        public IDevType PropertyType { get; }

        public string Name { get; }

        public Visibility GetVisibility { get; }

        public Visibility SetVisibility { get; }
    }
}
