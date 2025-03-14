// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Labeling job definition. </summary>
    public partial class LabelingJobProperties : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="LabelingJobProperties"/>. </summary>
        public LabelingJobProperties()
        {
            LabelCategories = new ChangeTrackingDictionary<string, LabelCategory>();
            StatusMessages = new ChangeTrackingList<JobStatusMessage>();
            JobType = JobType.Labeling;
        }

        /// <summary> Initializes a new instance of <see cref="LabelingJobProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="secretsConfiguration"> Configuration for secrets to be made available during runtime. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="createdOn"> Created time of the job in UTC timezone. </param>
        /// <param name="dataConfiguration"> Configuration of data used in the job. </param>
        /// <param name="jobInstructions"> Labeling instructions of the job. </param>
        /// <param name="labelCategories"> Label categories of the job. </param>
        /// <param name="labelingJobMediaProperties">
        /// Media type specific properties in the job.
        /// Please note <see cref="Models.LabelingJobMediaProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LabelingJobImageProperties"/> and <see cref="LabelingJobTextProperties"/>.
        /// </param>
        /// <param name="mlAssistConfiguration">
        /// Configuration of MLAssist feature in the job.
        /// Please note <see cref="MachineLearningAssistConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MLAssistConfigurationDisabled"/> and <see cref="MachineLearningAssistEnabledConfiguration"/>.
        /// </param>
        /// <param name="progressMetrics"> Progress metrics of the job. </param>
        /// <param name="projectId"> Internal id of the job(Previously called project). </param>
        /// <param name="provisioningState"> Specifies the labeling job provisioning state. </param>
        /// <param name="statusMessages"> Status messages of the job. </param>
        internal LabelingJobProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, ResourceIdentifier componentId, ResourceIdentifier computeId, string displayName, string experimentName, MachineLearningIdentityConfiguration identity, bool? isArchived, JobType jobType, NotificationSetting notificationSetting, IDictionary<string, SecretConfiguration> secretsConfiguration, IDictionary<string, MachineLearningJobService> services, MachineLearningJobStatus? status, DateTimeOffset? createdOn, LabelingDataConfiguration dataConfiguration, LabelingJobInstructions jobInstructions, IDictionary<string, LabelCategory> labelCategories, LabelingJobMediaProperties labelingJobMediaProperties, MachineLearningAssistConfiguration mlAssistConfiguration, ProgressMetrics progressMetrics, Guid? projectId, JobProvisioningState? provisioningState, IReadOnlyList<JobStatusMessage> statusMessages) : base(description, properties, tags, componentId, computeId, displayName, experimentName, identity, isArchived, jobType, notificationSetting, secretsConfiguration, services, status)
        {
            CreatedOn = createdOn;
            DataConfiguration = dataConfiguration;
            JobInstructions = jobInstructions;
            LabelCategories = labelCategories;
            LabelingJobMediaProperties = labelingJobMediaProperties;
            MlAssistConfiguration = mlAssistConfiguration;
            ProgressMetrics = progressMetrics;
            ProjectId = projectId;
            ProvisioningState = provisioningState;
            StatusMessages = statusMessages;
            JobType = jobType;
        }

        /// <summary> Created time of the job in UTC timezone. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Configuration of data used in the job. </summary>
        public LabelingDataConfiguration DataConfiguration { get; set; }
        /// <summary> Labeling instructions of the job. </summary>
        internal LabelingJobInstructions JobInstructions { get; set; }
        /// <summary> The link to a page with detailed labeling instructions for labelers. </summary>
        public Uri JobInstructionsUri
        {
            get => JobInstructions is null ? default : JobInstructions.Uri;
            set
            {
                if (JobInstructions is null)
                    JobInstructions = new LabelingJobInstructions();
                JobInstructions.Uri = value;
            }
        }

        /// <summary> Label categories of the job. </summary>
        public IDictionary<string, LabelCategory> LabelCategories { get; set; }
        /// <summary>
        /// Media type specific properties in the job.
        /// Please note <see cref="Models.LabelingJobMediaProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LabelingJobImageProperties"/> and <see cref="LabelingJobTextProperties"/>.
        /// </summary>
        public LabelingJobMediaProperties LabelingJobMediaProperties { get; set; }
        /// <summary>
        /// Configuration of MLAssist feature in the job.
        /// Please note <see cref="MachineLearningAssistConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MLAssistConfigurationDisabled"/> and <see cref="MachineLearningAssistEnabledConfiguration"/>.
        /// </summary>
        public MachineLearningAssistConfiguration MlAssistConfiguration { get; set; }
        /// <summary> Progress metrics of the job. </summary>
        public ProgressMetrics ProgressMetrics { get; }
        /// <summary> Internal id of the job(Previously called project). </summary>
        public Guid? ProjectId { get; }
        /// <summary> Specifies the labeling job provisioning state. </summary>
        public JobProvisioningState? ProvisioningState { get; }
        /// <summary> Status messages of the job. </summary>
        public IReadOnlyList<JobStatusMessage> StatusMessages { get; }
    }
}
