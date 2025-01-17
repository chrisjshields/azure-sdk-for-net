// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Evaluation details of IfNotExists effect. </summary>
    public partial class IfNotExistsEvaluationDetails
    {
        /// <summary> Initializes a new instance of IfNotExistsEvaluationDetails. </summary>
        internal IfNotExistsEvaluationDetails()
        {
        }

        /// <summary> Initializes a new instance of IfNotExistsEvaluationDetails. </summary>
        /// <param name="resourceId"> ID of the last evaluated resource for IfNotExists effect. </param>
        /// <param name="totalResources"> Total number of resources to which the existence condition is applicable. </param>
        internal IfNotExistsEvaluationDetails(ResourceIdentifier resourceId, int? totalResources)
        {
            ResourceId = resourceId;
            TotalResources = totalResources;
        }

        /// <summary> ID of the last evaluated resource for IfNotExists effect. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Total number of resources to which the existence condition is applicable. </summary>
        public int? TotalResources { get; }
    }
}
