// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The health data for an endpoint. </summary>
    public partial class IotHubEndpointHealthInfo
    {
        /// <summary> Initializes a new instance of <see cref="IotHubEndpointHealthInfo"/>. </summary>
        internal IotHubEndpointHealthInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotHubEndpointHealthInfo"/>. </summary>
        /// <param name="endpointId"> Id of the endpoint. </param>
        /// <param name="healthStatus"> Health statuses have following meanings. The 'healthy' status shows that the endpoint is accepting messages as expected. The 'unhealthy' status shows that the endpoint is not accepting messages as expected and IoT Hub is retrying to send data to this endpoint. The status of an unhealthy endpoint will be updated to healthy when IoT Hub has established an eventually consistent state of health. The 'dead' status shows that the endpoint is not accepting messages, after IoT Hub retried sending messages for the retrial period. See IoT Hub metrics to identify errors and monitor issues with endpoints. The 'unknown' status shows that the IoT Hub has not established a connection with the endpoint. No messages have been delivered to or rejected from this endpoint. </param>
        /// <param name="lastKnownError"> Last error obtained when a message failed to be delivered to iot hub. </param>
        /// <param name="lastKnownErrorOn"> Time at which the last known error occurred. </param>
        /// <param name="lastSuccessfulSendAttemptOn"> Last time iot hub successfully sent a message to the endpoint. </param>
        /// <param name="lastSendAttemptOn"> Last time iot hub tried to send a message to the endpoint. </param>
        internal IotHubEndpointHealthInfo(string endpointId, IotHubEndpointHealthStatus? healthStatus, string lastKnownError, DateTimeOffset? lastKnownErrorOn, DateTimeOffset? lastSuccessfulSendAttemptOn, DateTimeOffset? lastSendAttemptOn)
        {
            EndpointId = endpointId;
            HealthStatus = healthStatus;
            LastKnownError = lastKnownError;
            LastKnownErrorOn = lastKnownErrorOn;
            LastSuccessfulSendAttemptOn = lastSuccessfulSendAttemptOn;
            LastSendAttemptOn = lastSendAttemptOn;
        }

        /// <summary> Id of the endpoint. </summary>
        public string EndpointId { get; }
        /// <summary> Health statuses have following meanings. The 'healthy' status shows that the endpoint is accepting messages as expected. The 'unhealthy' status shows that the endpoint is not accepting messages as expected and IoT Hub is retrying to send data to this endpoint. The status of an unhealthy endpoint will be updated to healthy when IoT Hub has established an eventually consistent state of health. The 'dead' status shows that the endpoint is not accepting messages, after IoT Hub retried sending messages for the retrial period. See IoT Hub metrics to identify errors and monitor issues with endpoints. The 'unknown' status shows that the IoT Hub has not established a connection with the endpoint. No messages have been delivered to or rejected from this endpoint. </summary>
        public IotHubEndpointHealthStatus? HealthStatus { get; }
        /// <summary> Last error obtained when a message failed to be delivered to iot hub. </summary>
        public string LastKnownError { get; }
        /// <summary> Time at which the last known error occurred. </summary>
        public DateTimeOffset? LastKnownErrorOn { get; }
        /// <summary> Last time iot hub successfully sent a message to the endpoint. </summary>
        public DateTimeOffset? LastSuccessfulSendAttemptOn { get; }
        /// <summary> Last time iot hub tried to send a message to the endpoint. </summary>
        public DateTimeOffset? LastSendAttemptOn { get; }
    }
}
