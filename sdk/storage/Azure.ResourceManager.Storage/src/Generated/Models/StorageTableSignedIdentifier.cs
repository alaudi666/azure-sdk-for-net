// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Object to set Table Access Policy. </summary>
    public partial class StorageTableSignedIdentifier
    {
        /// <summary> Initializes a new instance of <see cref="StorageTableSignedIdentifier"/>. </summary>
        /// <param name="id"> unique-64-character-value of the stored access policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public StorageTableSignedIdentifier(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="StorageTableSignedIdentifier"/>. </summary>
        /// <param name="id"> unique-64-character-value of the stored access policy. </param>
        /// <param name="accessPolicy"> Access policy. </param>
        internal StorageTableSignedIdentifier(string id, StorageTableAccessPolicy accessPolicy)
        {
            Id = id;
            AccessPolicy = accessPolicy;
        }

        /// <summary> unique-64-character-value of the stored access policy. </summary>
        public string Id { get; set; }
        /// <summary> Access policy. </summary>
        public StorageTableAccessPolicy AccessPolicy { get; set; }
    }
}
