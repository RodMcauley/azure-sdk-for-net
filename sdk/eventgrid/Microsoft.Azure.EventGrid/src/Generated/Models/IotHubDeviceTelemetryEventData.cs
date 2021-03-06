// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Event data for Microsoft.Devices.DeviceTelemetry event.
    /// </summary>
    public partial class IotHubDeviceTelemetryEventData : DeviceTelemetryEventProperties
    {
        /// <summary>
        /// Initializes a new instance of the IotHubDeviceTelemetryEventData
        /// class.
        /// </summary>
        public IotHubDeviceTelemetryEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubDeviceTelemetryEventData
        /// class.
        /// </summary>
        /// <param name="body">The content of the message from the
        /// device.</param>
        /// <param name="properties">Application properties are user-defined
        /// strings that can be added to the message. These fields are
        /// optional.</param>
        /// <param name="systemProperties">System properties help identify
        /// contents and source of the messages.</param>
        public IotHubDeviceTelemetryEventData(object body = default(object), IDictionary<string, string> properties = default(IDictionary<string, string>), IDictionary<string, string> systemProperties = default(IDictionary<string, string>))
            : base(body, properties, systemProperties)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
