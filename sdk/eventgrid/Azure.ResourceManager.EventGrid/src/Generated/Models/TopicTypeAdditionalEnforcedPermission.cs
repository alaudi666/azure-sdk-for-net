// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The TopicTypeAdditionalEnforcedPermission. </summary>
    public partial class TopicTypeAdditionalEnforcedPermission
    {
        /// <summary> Initializes a new instance of <see cref="TopicTypeAdditionalEnforcedPermission"/>. </summary>
        public TopicTypeAdditionalEnforcedPermission()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TopicTypeAdditionalEnforcedPermission"/>. </summary>
        /// <param name="permissionName"></param>
        /// <param name="isDataAction"></param>
        internal TopicTypeAdditionalEnforcedPermission(string permissionName, bool? isDataAction)
        {
            PermissionName = permissionName;
            IsDataAction = isDataAction;
        }

        /// <summary> Gets or sets the permission name. </summary>
        public string PermissionName { get; set; }
        /// <summary> Gets or sets the is data action. </summary>
        public bool? IsDataAction { get; set; }
    }
}
