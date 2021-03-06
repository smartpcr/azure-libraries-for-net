// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AlertEmailNotificationStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertEmailNotificationStatus
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class AlertEmailNotificationStatusEnumExtension
    {
        internal static string ToSerializedValue(this AlertEmailNotificationStatus? value)
        {
            return value == null ? null : ((AlertEmailNotificationStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertEmailNotificationStatus value)
        {
            switch( value )
            {
                case AlertEmailNotificationStatus.Enabled:
                    return "Enabled";
                case AlertEmailNotificationStatus.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static AlertEmailNotificationStatus? ParseAlertEmailNotificationStatus(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return AlertEmailNotificationStatus.Enabled;
                case "Disabled":
                    return AlertEmailNotificationStatus.Disabled;
            }
            return null;
        }
    }
}
