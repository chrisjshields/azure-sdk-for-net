// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// Data Lake Analytics account name availability check parameters.
    /// Serialized Name: CheckNameAvailabilityParameters
    /// </summary>
    public partial class DataLakeAnalyticsAccountNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsAccountNameAvailabilityContent. </summary>
        /// <param name="name">
        /// The Data Lake Analytics name to check availability for.
        /// Serialized Name: CheckNameAvailabilityParameters.name
        /// </param>
        /// <param name="resourceType">
        /// The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeAnalytics/accounts
        /// Serialized Name: CheckNameAvailabilityParameters.type
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataLakeAnalyticsAccountNameAvailabilityContent(string name, DataLakeAnalyticsResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary>
        /// The Data Lake Analytics name to check availability for.
        /// Serialized Name: CheckNameAvailabilityParameters.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeAnalytics/accounts
        /// Serialized Name: CheckNameAvailabilityParameters.type
        /// </summary>
        public DataLakeAnalyticsResourceType ResourceType { get; }
    }
}
