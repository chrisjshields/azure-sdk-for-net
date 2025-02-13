// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// Data Lake Analytics account name availability result information.
    /// Serialized Name: NameAvailabilityInformation
    /// </summary>
    public partial class DataLakeAnalyticsAccountNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsAccountNameAvailabilityResult. </summary>
        internal DataLakeAnalyticsAccountNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsAccountNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable">
        /// The Boolean value of true or false to indicate whether the Data Lake Analytics account name is available or not.
        /// Serialized Name: NameAvailabilityInformation.nameAvailable
        /// </param>
        /// <param name="reason">
        /// The reason why the Data Lake Analytics account name is not available, if nameAvailable is false.
        /// Serialized Name: NameAvailabilityInformation.reason
        /// </param>
        /// <param name="message">
        /// The message describing why the Data Lake Analytics account name is not available, if nameAvailable is false.
        /// Serialized Name: NameAvailabilityInformation.message
        /// </param>
        internal DataLakeAnalyticsAccountNameAvailabilityResult(bool? isNameAvailable, string reason, string message)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// The Boolean value of true or false to indicate whether the Data Lake Analytics account name is available or not.
        /// Serialized Name: NameAvailabilityInformation.nameAvailable
        /// </summary>
        public bool? IsNameAvailable { get; }
        /// <summary>
        /// The reason why the Data Lake Analytics account name is not available, if nameAvailable is false.
        /// Serialized Name: NameAvailabilityInformation.reason
        /// </summary>
        public string Reason { get; }
        /// <summary>
        /// The message describing why the Data Lake Analytics account name is not available, if nameAvailable is false.
        /// Serialized Name: NameAvailabilityInformation.message
        /// </summary>
        public string Message { get; }
    }
}
