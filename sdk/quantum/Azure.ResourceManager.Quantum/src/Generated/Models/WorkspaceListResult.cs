// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Quantum;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> The response of a list Workspaces operation. </summary>
    internal partial class WorkspaceListResult
    {
        /// <summary> Initializes a new instance of <see cref="WorkspaceListResult"/>. </summary>
        internal WorkspaceListResult()
        {
            Value = new ChangeTrackingList<QuantumWorkspaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceListResult"/>. </summary>
        /// <param name="value"> Result of a list Workspaces operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of Workspaces. </param>
        internal WorkspaceListResult(IReadOnlyList<QuantumWorkspaceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of a list Workspaces operation. </summary>
        public IReadOnlyList<QuantumWorkspaceData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of Workspaces. </summary>
        public string NextLink { get; }
    }
}
