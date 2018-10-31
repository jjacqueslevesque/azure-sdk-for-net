// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Trigger that creates pipeline runs periodically, on schedule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScheduleTrigger : MultiplePipelineTrigger
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleTrigger class.
        /// </summary>
        public ScheduleTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleTrigger class.
        /// </summary>
        /// <param name="recurrence">Recurrence schedule configuration.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Trigger description.</param>
        /// <param name="runtimeState">Indicates if trigger is running or not.
        /// Updated when Start/Stop APIs are called on the Trigger. Possible
        /// values include: 'Started', 'Stopped', 'Disabled'</param>
        /// <param name="pipelines">Pipelines that need to be started.</param>
        public ScheduleTrigger(ScheduleTriggerRecurrence recurrence, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), string runtimeState = default(string), IList<TriggerPipelineReference> pipelines = default(IList<TriggerPipelineReference>))
            : base(additionalProperties, description, runtimeState, pipelines)
        {
            Recurrence = recurrence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets recurrence schedule configuration.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.recurrence")]
        public ScheduleTriggerRecurrence Recurrence { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Recurrence == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Recurrence");
            }
        }
    }
}