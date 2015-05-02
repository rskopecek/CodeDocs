﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Globalization;
using CodeDocs.Helpers;

namespace CodeDocs
{

    public abstract class CodeDocsAttribute : CodeDocsBaseAttribute, ICodeDocsAttribute
    {

        protected CodeDocsAttribute(string details, Risk? risk, Effort? effort, int? yyyymmdd,
            params string[] metadata)
        {
            Details = details;
            Risk = risk ?? Risk.Unknown;
            Effort = effort ?? Effort.Unknown;
            Date = yyyymmdd.ToDate();
            Metadata = metadata;
        }


        public abstract IDefinition Definition { get; }

        public DateTime? Date { get; private set; }

        public Risk Risk { get; private set; }

        public Effort Effort { get; private set; }

        public string Details { get; private set; }

        public string[] Metadata { get; private set; }


        /// <summary>
        /// Gets the risk using the default evaluator. (returns Risk ?? Default.Override ?? Default)
        /// </summary>
        public Risk GetRisk()
        {
            return GetRisk(QualityEvaluator.Default);
        }

        /// <summary>
        /// Gets the risk using the provided evaluator. (returns Risk ?? Default.Override ?? Default)
        /// </summary>
        public Risk GetRisk(IQualityEvaluator evaluator)
        {
            var riskOverride = evaluator.GetRiskOverride(this);

            return riskOverride ?? QualityEvaluator.Default.GetDefaultRisk(this);
        }

        /// <summary>
        /// Gets the effort using the default evaluator. (returns Effort ?? Default.Override ?? Default)
        /// </summary>
        public Effort GetEffort()
        {
            return GetEffort(QualityEvaluator.Default);
        }

        /// <summary>
        /// Gets the effort using the provided evaluator. (returns Effort ?? Default.Override ?? Default)
        /// </summary>
        public Effort GetEffort(IQualityEvaluator evaluator)
        {
            var effortOverride = evaluator.GetEffortOverride(this);

            return effortOverride ?? QualityEvaluator.Default.GetDefaultEffort(this);
        }

        /// <summary>
        /// MetaRisk is an evaluation of the quality of the usage of a CodeDocsAttribute itself.  Gets the metarisk using the default evaluator. (returns MetaRisk ?? Default.Override ?? Default)
        /// </summary>
        public Risk GetMetaRisk()
        {
            return GetMetaRisk(QualityEvaluator.Default);
        }

        /// <summary>
        /// MetaRisk is an evaluation of the quality of the usage of a CodeDocsAttribute itself.  Gets the metarisk using the provided evaluator. (returns MetaRisk ?? Default.Override ?? Default)
        /// </summary>
        public Risk GetMetaRisk(IQualityEvaluator evaluator)
        {
            return evaluator.GetMetaRiskOverride(this) ?? QualityEvaluator.Default.GetDefaultMetaRisk(this);
        }
    }

}
