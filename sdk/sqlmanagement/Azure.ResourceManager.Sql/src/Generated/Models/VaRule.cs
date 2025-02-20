// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> SQL Vulnerability Assessment rule metadata details. </summary>
    public partial class VaRule
    {
        /// <summary> Initializes a new instance of VaRule. </summary>
        internal VaRule()
        {
            BenchmarkReferences = new ChangeTrackingList<BenchmarkReference>();
        }

        /// <summary> Initializes a new instance of VaRule. </summary>
        /// <param name="ruleId"> SQL Vulnerability Assessment rule Id. </param>
        /// <param name="severity"> SQL Vulnerability Assessment rule severity. </param>
        /// <param name="category"> SQL Vulnerability Assessment rule category. </param>
        /// <param name="ruleType"> SQL Vulnerability Assessment rule type. </param>
        /// <param name="title"> SQL Vulnerability Assessment rule title. </param>
        /// <param name="description"> SQL Vulnerability Assessment rule description. </param>
        /// <param name="rationale"> SQL Vulnerability Assessment rule rationale. </param>
        /// <param name="queryCheck"> SQL Vulnerability Assessment rule query details. </param>
        /// <param name="benchmarkReferences"> SQL Vulnerability Assessment benchmark references. </param>
        internal VaRule(string ruleId, RuleSeverity? severity, string category, RuleType? ruleType, string title, string description, string rationale, QueryCheck queryCheck, IReadOnlyList<BenchmarkReference> benchmarkReferences)
        {
            RuleId = ruleId;
            Severity = severity;
            Category = category;
            RuleType = ruleType;
            Title = title;
            Description = description;
            Rationale = rationale;
            QueryCheck = queryCheck;
            BenchmarkReferences = benchmarkReferences;
        }

        /// <summary> SQL Vulnerability Assessment rule Id. </summary>
        public string RuleId { get; }
        /// <summary> SQL Vulnerability Assessment rule severity. </summary>
        public RuleSeverity? Severity { get; }
        /// <summary> SQL Vulnerability Assessment rule category. </summary>
        public string Category { get; }
        /// <summary> SQL Vulnerability Assessment rule type. </summary>
        public RuleType? RuleType { get; }
        /// <summary> SQL Vulnerability Assessment rule title. </summary>
        public string Title { get; }
        /// <summary> SQL Vulnerability Assessment rule description. </summary>
        public string Description { get; }
        /// <summary> SQL Vulnerability Assessment rule rationale. </summary>
        public string Rationale { get; }
        /// <summary> SQL Vulnerability Assessment rule query details. </summary>
        public QueryCheck QueryCheck { get; }
        /// <summary> SQL Vulnerability Assessment benchmark references. </summary>
        public IReadOnlyList<BenchmarkReference> BenchmarkReferences { get; }
    }
}
