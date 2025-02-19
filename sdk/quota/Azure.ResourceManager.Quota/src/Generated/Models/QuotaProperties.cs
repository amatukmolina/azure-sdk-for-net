// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Quota properties for the specified resource. </summary>
    public partial class QuotaProperties
    {
        /// <summary> Initializes a new instance of QuotaProperties. </summary>
        public QuotaProperties()
        {
        }

        /// <summary> Initializes a new instance of QuotaProperties. </summary>
        /// <param name="limit">
        /// Resource quota limit properties.
        /// Please note <see cref="QuotaLimitJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="QuotaLimitObject"/>.
        /// </param>
        /// <param name="unit"> The quota units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </param>
        /// <param name="name"> Resource name provided by the resource provider. Use this property name when requesting quota. </param>
        /// <param name="resourceTypeName"> The name of the resource type. Optional field. </param>
        /// <param name="quotaPeriod">
        /// The time period over which the quota usage values are summarized. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because, for some resources like compute, the period is irrelevant.
        /// </param>
        /// <param name="isQuotaApplicable"> States if quota can be requested for this resource. </param>
        /// <param name="properties"> Additional properties for the specific resource provider. </param>
        internal QuotaProperties(QuotaLimitJsonObject limit, string unit, QuotaRequestResourceName name, string resourceTypeName, TimeSpan? quotaPeriod, bool? isQuotaApplicable, BinaryData properties)
        {
            Limit = limit;
            Unit = unit;
            Name = name;
            ResourceTypeName = resourceTypeName;
            QuotaPeriod = quotaPeriod;
            IsQuotaApplicable = isQuotaApplicable;
            Properties = properties;
        }

        /// <summary>
        /// Resource quota limit properties.
        /// Please note <see cref="QuotaLimitJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="QuotaLimitObject"/>.
        /// </summary>
        public QuotaLimitJsonObject Limit { get; set; }
        /// <summary> The quota units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </summary>
        public string Unit { get; }
        /// <summary> Resource name provided by the resource provider. Use this property name when requesting quota. </summary>
        public QuotaRequestResourceName Name { get; set; }
        /// <summary> The name of the resource type. Optional field. </summary>
        public string ResourceTypeName { get; set; }
        /// <summary>
        /// The time period over which the quota usage values are summarized. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because, for some resources like compute, the period is irrelevant.
        /// </summary>
        public TimeSpan? QuotaPeriod { get; }
        /// <summary> States if quota can be requested for this resource. </summary>
        public bool? IsQuotaApplicable { get; }
        /// <summary>
        /// Additional properties for the specific resource provider.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Properties { get; set; }
    }
}
