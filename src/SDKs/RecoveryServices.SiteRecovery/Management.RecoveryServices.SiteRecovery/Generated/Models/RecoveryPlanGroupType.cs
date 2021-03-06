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
    /// Defines values for RecoveryPlanGroupType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecoveryPlanGroupType
    {
        [EnumMember(Value = "Shutdown")]
        Shutdown,
        [EnumMember(Value = "Boot")]
        Boot,
        [EnumMember(Value = "Failover")]
        Failover
    }
    internal static class RecoveryPlanGroupTypeEnumExtension
    {
        internal static string ToSerializedValue(this RecoveryPlanGroupType? value)
        {
            return value == null ? null : ((RecoveryPlanGroupType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RecoveryPlanGroupType value)
        {
            switch( value )
            {
                case RecoveryPlanGroupType.Shutdown:
                    return "Shutdown";
                case RecoveryPlanGroupType.Boot:
                    return "Boot";
                case RecoveryPlanGroupType.Failover:
                    return "Failover";
            }
            return null;
        }

        internal static RecoveryPlanGroupType? ParseRecoveryPlanGroupType(this string value)
        {
            switch( value )
            {
                case "Shutdown":
                    return RecoveryPlanGroupType.Shutdown;
                case "Boot":
                    return RecoveryPlanGroupType.Boot;
                case "Failover":
                    return RecoveryPlanGroupType.Failover;
            }
            return null;
        }
    }
}
