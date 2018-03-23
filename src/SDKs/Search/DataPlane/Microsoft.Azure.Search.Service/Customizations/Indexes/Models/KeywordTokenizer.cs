// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Emits the entire input as a single token. This tokenizer is
    /// implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/core/KeywordTokenizer.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.KeywordTokenizer")]
    [Obsolete("This type is obsolete. Please use KeywordTokenizerV2 instead.")]
    public partial class KeywordTokenizer : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the KeywordTokenizer class.
        /// </summary>
        public KeywordTokenizer() { }

        /// <summary>
        /// Initializes a new instance of the KeywordTokenizer class.
        /// </summary>
        public KeywordTokenizer(string name, int? bufferSize = default(int?))
            : base(name)
        {
            BufferSize = bufferSize;
        }

        /// <summary>
        /// Gets or sets the read buffer size in bytes. Default is 256.
        /// </summary>
        [JsonProperty(PropertyName = "bufferSize")]
        public int? BufferSize { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}