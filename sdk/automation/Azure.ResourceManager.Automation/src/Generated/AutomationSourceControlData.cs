// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationSourceControl data model.
    /// Definition of the source control.
    /// </summary>
    public partial class AutomationSourceControlData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AutomationSourceControlData"/>. </summary>
        public AutomationSourceControlData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationSourceControlData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="repoUri"> The repo url of the source control. </param>
        /// <param name="branch"> The repo branch of the source control. Include branch as empty string for VsoTfvc. </param>
        /// <param name="folderPath"> The folder path of the source control. </param>
        /// <param name="isAutoSyncEnabled"> The auto sync of the source control. Default is false. </param>
        /// <param name="isAutoPublishRunbookEnabled"> The auto publish of the source control. Default is true. </param>
        /// <param name="sourceType"> The source type. Must be one of VsoGit, VsoTfvc, GitHub. </param>
        /// <param name="description"> The description. </param>
        /// <param name="createdOn"> The creation time. </param>
        /// <param name="lastModifiedOn"> The last modified time. </param>
        internal AutomationSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri repoUri, string branch, string folderPath, bool? isAutoSyncEnabled, bool? isAutoPublishRunbookEnabled, SourceControlSourceType? sourceType, string description, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn) : base(id, name, resourceType, systemData)
        {
            RepoUri = repoUri;
            Branch = branch;
            FolderPath = folderPath;
            IsAutoSyncEnabled = isAutoSyncEnabled;
            IsAutoPublishRunbookEnabled = isAutoPublishRunbookEnabled;
            SourceType = sourceType;
            Description = description;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
        }

        /// <summary> The repo url of the source control. </summary>
        public Uri RepoUri { get; set; }
        /// <summary> The repo branch of the source control. Include branch as empty string for VsoTfvc. </summary>
        public string Branch { get; set; }
        /// <summary> The folder path of the source control. </summary>
        public string FolderPath { get; set; }
        /// <summary> The auto sync of the source control. Default is false. </summary>
        public bool? IsAutoSyncEnabled { get; set; }
        /// <summary> The auto publish of the source control. Default is true. </summary>
        public bool? IsAutoPublishRunbookEnabled { get; set; }
        /// <summary> The source type. Must be one of VsoGit, VsoTfvc, GitHub. </summary>
        public SourceControlSourceType? SourceType { get; set; }
        /// <summary> The description. </summary>
        public string Description { get; set; }
        /// <summary> The creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
    }
}
