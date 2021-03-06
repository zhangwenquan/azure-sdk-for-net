// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FailoverDeploymentModel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FailoverDeploymentModel
    {
        [EnumMember(Value = "NotApplicable")]
        NotApplicable,
        [EnumMember(Value = "Classic")]
        Classic,
        [EnumMember(Value = "ResourceManager")]
        ResourceManager
    }
    internal static class FailoverDeploymentModelEnumExtension
    {
        internal static string ToSerializedValue(this FailoverDeploymentModel? value)
        {
            return value == null ? null : ((FailoverDeploymentModel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FailoverDeploymentModel value)
        {
            switch( value )
            {
                case FailoverDeploymentModel.NotApplicable:
                    return "NotApplicable";
                case FailoverDeploymentModel.Classic:
                    return "Classic";
                case FailoverDeploymentModel.ResourceManager:
                    return "ResourceManager";
            }
            return null;
        }

        internal static FailoverDeploymentModel? ParseFailoverDeploymentModel(this string value)
        {
            switch( value )
            {
                case "NotApplicable":
                    return FailoverDeploymentModel.NotApplicable;
                case "Classic":
                    return FailoverDeploymentModel.Classic;
                case "ResourceManager":
                    return FailoverDeploymentModel.ResourceManager;
            }
            return null;
        }
    }
}
