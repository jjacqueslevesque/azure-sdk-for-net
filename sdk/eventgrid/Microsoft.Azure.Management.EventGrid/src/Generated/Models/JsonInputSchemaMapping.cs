// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This enables publishing to Event Grid using a custom input schema. This
    /// can be used to map properties from a custom input JSON schema to the
    /// Event Grid event schema.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Json")]
    [Rest.Serialization.JsonTransformation]
    public partial class JsonInputSchemaMapping : InputSchemaMapping
    {
        /// <summary>
        /// Initializes a new instance of the JsonInputSchemaMapping class.
        /// </summary>
        public JsonInputSchemaMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonInputSchemaMapping class.
        /// </summary>
        /// <param name="id">The mapping information for the Id property of the
        /// Event Grid Event.</param>
        /// <param name="topic">The mapping information for the Topic property
        /// of the Event Grid Event.</param>
        /// <param name="eventTime">The mapping information for the EventTime
        /// property of the Event Grid Event.</param>
        /// <param name="eventType">The mapping information for the EventType
        /// property of the Event Grid Event.</param>
        /// <param name="subject">The mapping information for the Subject
        /// property of the Event Grid Event.</param>
        /// <param name="dataVersion">The mapping information for the
        /// DataVersion property of the Event Grid Event.</param>
        public JsonInputSchemaMapping(JsonField id = default(JsonField), JsonField topic = default(JsonField), JsonField eventTime = default(JsonField), JsonFieldWithDefault eventType = default(JsonFieldWithDefault), JsonFieldWithDefault subject = default(JsonFieldWithDefault), JsonFieldWithDefault dataVersion = default(JsonFieldWithDefault))
        {
            Id = id;
            Topic = topic;
            EventTime = eventTime;
            EventType = eventType;
            Subject = subject;
            DataVersion = dataVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mapping information for the Id property of the
        /// Event Grid Event.
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public JsonField Id { get; set; }

        /// <summary>
        /// Gets or sets the mapping information for the Topic property of the
        /// Event Grid Event.
        /// </summary>
        [JsonProperty(PropertyName = "properties.topic")]
        public JsonField Topic { get; set; }

        /// <summary>
        /// Gets or sets the mapping information for the EventTime property of
        /// the Event Grid Event.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventTime")]
        public JsonField EventTime { get; set; }

        /// <summary>
        /// Gets or sets the mapping information for the EventType property of
        /// the Event Grid Event.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventType")]
        public JsonFieldWithDefault EventType { get; set; }

        /// <summary>
        /// Gets or sets the mapping information for the Subject property of
        /// the Event Grid Event.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subject")]
        public JsonFieldWithDefault Subject { get; set; }

        /// <summary>
        /// Gets or sets the mapping information for the DataVersion property
        /// of the Event Grid Event.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataVersion")]
        public JsonFieldWithDefault DataVersion { get; set; }

    }
}
