// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for the command that completes sync migration for a
    /// database.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Migrate.Sync.Complete.Database")]
    public partial class MigrateSyncCompleteCommandProperties : CommandProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSyncCompleteCommandProperties class.
        /// </summary>
        public MigrateSyncCompleteCommandProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSyncCompleteCommandProperties class.
        /// </summary>
        /// <param name="errors">Array of errors. This is ignored if
        /// submitted.</param>
        /// <param name="state">The state of the command. This is ignored if
        /// submitted. Possible values include: 'Unknown', 'Accepted',
        /// 'Running', 'Succeeded', 'Failed'</param>
        /// <param name="input">Command input</param>
        /// <param name="output">Command output. This is ignored if
        /// submitted.</param>
        public MigrateSyncCompleteCommandProperties(IList<ODataError> errors = default(IList<ODataError>), string state = default(string), MigrateSyncCompleteCommandInput input = default(MigrateSyncCompleteCommandInput), MigrateSyncCompleteCommandOutput output = default(MigrateSyncCompleteCommandOutput))
            : base(errors, state)
        {
            Input = input;
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command input
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public MigrateSyncCompleteCommandInput Input { get; set; }

        /// <summary>
        /// Gets command output. This is ignored if submitted.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public MigrateSyncCompleteCommandOutput Output { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Input != null)
            {
                Input.Validate();
            }
        }
    }
}
