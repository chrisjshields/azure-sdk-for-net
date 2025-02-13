// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Azure Blob Storage content. </summary>
    public partial class AzureBlobContentSource
    {
        /// <summary> Initializes a new instance of AzureBlobContentSource. </summary>
        /// <param name="containerUri"> Azure Blob Storage container URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerUri"/> is null. </exception>
        public AzureBlobContentSource(Uri containerUri)
        {
            Argument.AssertNotNull(containerUri, nameof(containerUri));

            ContainerUri = containerUri;
        }

        /// <summary> Initializes a new instance of AzureBlobContentSource. </summary>
        /// <param name="containerUri"> Azure Blob Storage container URL. </param>
        /// <param name="prefix"> Blob name prefix. </param>
        internal AzureBlobContentSource(Uri containerUri, string prefix)
        {
            ContainerUri = containerUri;
            Prefix = prefix;
        }
        /// <summary> Blob name prefix. </summary>
        public string Prefix { get; set; }
    }
}
