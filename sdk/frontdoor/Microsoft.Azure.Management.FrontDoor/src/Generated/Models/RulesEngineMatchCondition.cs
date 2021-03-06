// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Define a match condition
    /// </summary>
    public partial class RulesEngineMatchCondition
    {
        /// <summary>
        /// Initializes a new instance of the RulesEngineMatchCondition class.
        /// </summary>
        public RulesEngineMatchCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RulesEngineMatchCondition class.
        /// </summary>
        /// <param name="rulesEngineMatchVariable">Match Variable. Possible
        /// values include: 'IsMobile', 'RemoteAddr', 'RequestMethod',
        /// 'QueryString', 'PostArgs', 'RequestUri', 'RequestPath',
        /// 'RequestFilename', 'RequestFilenameExtension', 'RequestHeader',
        /// 'RequestBody', 'RequestScheme'</param>
        /// <param name="rulesEngineOperator">Describes operator to apply to
        /// the match condition. Possible values include: 'Any', 'IPMatch',
        /// 'GeoMatch', 'Equal', 'Contains', 'LessThan', 'GreaterThan',
        /// 'LessThanOrEqual', 'GreaterThanOrEqual', 'BeginsWith',
        /// 'EndsWith'</param>
        /// <param name="rulesEngineMatchValue">Match values to match against.
        /// The operator will apply to each value in here with OR semantics. If
        /// any of them match the variable with the given operator this match
        /// condition is considered a match.</param>
        /// <param name="selector">Name of selector in RequestHeader or
        /// RequestBody to be matched</param>
        /// <param name="negateCondition">Describes if this is negate condition
        /// or not</param>
        /// <param name="transforms">List of transforms</param>
        public RulesEngineMatchCondition(string rulesEngineMatchVariable, string rulesEngineOperator, IList<string> rulesEngineMatchValue, string selector = default(string), bool? negateCondition = default(bool?), IList<string> transforms = default(IList<string>))
        {
            RulesEngineMatchVariable = rulesEngineMatchVariable;
            Selector = selector;
            RulesEngineOperator = rulesEngineOperator;
            NegateCondition = negateCondition;
            RulesEngineMatchValue = rulesEngineMatchValue;
            Transforms = transforms;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets match Variable. Possible values include: 'IsMobile',
        /// 'RemoteAddr', 'RequestMethod', 'QueryString', 'PostArgs',
        /// 'RequestUri', 'RequestPath', 'RequestFilename',
        /// 'RequestFilenameExtension', 'RequestHeader', 'RequestBody',
        /// 'RequestScheme'
        /// </summary>
        [JsonProperty(PropertyName = "rulesEngineMatchVariable")]
        public string RulesEngineMatchVariable { get; set; }

        /// <summary>
        /// Gets or sets name of selector in RequestHeader or RequestBody to be
        /// matched
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public string Selector { get; set; }

        /// <summary>
        /// Gets or sets describes operator to apply to the match condition.
        /// Possible values include: 'Any', 'IPMatch', 'GeoMatch', 'Equal',
        /// 'Contains', 'LessThan', 'GreaterThan', 'LessThanOrEqual',
        /// 'GreaterThanOrEqual', 'BeginsWith', 'EndsWith'
        /// </summary>
        [JsonProperty(PropertyName = "rulesEngineOperator")]
        public string RulesEngineOperator { get; set; }

        /// <summary>
        /// Gets or sets describes if this is negate condition or not
        /// </summary>
        [JsonProperty(PropertyName = "negateCondition")]
        public bool? NegateCondition { get; set; }

        /// <summary>
        /// Gets or sets match values to match against. The operator will apply
        /// to each value in here with OR semantics. If any of them match the
        /// variable with the given operator this match condition is considered
        /// a match.
        /// </summary>
        [JsonProperty(PropertyName = "rulesEngineMatchValue")]
        public IList<string> RulesEngineMatchValue { get; set; }

        /// <summary>
        /// Gets or sets list of transforms
        /// </summary>
        [JsonProperty(PropertyName = "transforms")]
        public IList<string> Transforms { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RulesEngineMatchVariable == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RulesEngineMatchVariable");
            }
            if (RulesEngineOperator == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RulesEngineOperator");
            }
            if (RulesEngineMatchValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RulesEngineMatchValue");
            }
        }
    }
}
