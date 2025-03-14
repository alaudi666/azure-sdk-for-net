// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The policy property value override. </summary>
    public partial class PolicyOverride
    {
        /// <summary> Initializes a new instance of <see cref="PolicyOverride"/>. </summary>
        public PolicyOverride()
        {
            Selectors = new ChangeTrackingList<ResourceSelectorExpression>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicyOverride"/>. </summary>
        /// <param name="kind"> The override kind. </param>
        /// <param name="value"> The value to override the policy property. </param>
        /// <param name="selectors"> The list of the selector expressions. </param>
        internal PolicyOverride(PolicyOverrideKind? kind, string value, IList<ResourceSelectorExpression> selectors)
        {
            Kind = kind;
            Value = value;
            Selectors = selectors;
        }

        /// <summary> The override kind. </summary>
        public PolicyOverrideKind? Kind { get; set; }
        /// <summary> The value to override the policy property. </summary>
        public string Value { get; set; }
        /// <summary> The list of the selector expressions. </summary>
        public IList<ResourceSelectorExpression> Selectors { get; }
    }
}
