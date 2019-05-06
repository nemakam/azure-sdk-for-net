// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The key verify result.
    /// </summary>
    public partial class KeyVerifyResult
    {
        /// <summary>
        /// Initializes a new instance of the KeyVerifyResult class.
        /// </summary>
        public KeyVerifyResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVerifyResult class.
        /// </summary>
        /// <param name="value">True if the signature is verified, otherwise
        /// false.</param>
        public KeyVerifyResult(bool? value = default(bool?))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets true if the signature is verified, otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public bool? Value { get; private set; }

    }
}