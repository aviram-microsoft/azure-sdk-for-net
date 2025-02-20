// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> A summary of the recommendation. </summary>
    public partial class ShortDescription
    {
        /// <summary> Initializes a new instance of ShortDescription. </summary>
        public ShortDescription()
        {
        }

        /// <summary> Initializes a new instance of ShortDescription. </summary>
        /// <param name="problem"> The issue or opportunity identified by the recommendation. </param>
        /// <param name="solution"> The remediation action suggested by the recommendation. </param>
        internal ShortDescription(string problem, string solution)
        {
            Problem = problem;
            Solution = solution;
        }

        /// <summary> The issue or opportunity identified by the recommendation. </summary>
        public string Problem { get; set; }
        /// <summary> The remediation action suggested by the recommendation. </summary>
        public string Solution { get; set; }
    }
}
