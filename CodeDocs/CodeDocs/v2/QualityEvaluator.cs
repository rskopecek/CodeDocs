using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeDocs.Definitions.v2;

namespace CodeDocs.v2
{
    public class QualityEvaluator : IQualityEvaluator
    {

        /// <summary>
        /// Default quality evaluator which guarantees values (not null) will be returned
        /// </summary>
        public static readonly QualityEvaluator Default = new QualityEvaluator();


        #region IQualityEvaluator Interface Adapters

        public Risk? GetRiskOverride(ICodeDocsAttribute att)
        {
            return GetDefaultRisk(att);
        }

        public Effort? GetEffortOverride(ICodeDocsAttribute att)
        {
            return GetDefaultEffort(att);
        }

        public Risk? GetMetaRiskOverride(ICodeDocsAttribute att)
        {
            return GetDefaultMetaRisk(att);
        }

        #endregion


        /// <summary>
        /// Always returns the Definition.DefaultRisk
        /// </summary>
        public Risk GetDefaultRisk(ICodeDocsAttribute att)
        {
            return att.Definition.DefaultRisk;
        }

        /// <summary>
        /// Always returns the Definition.DefaultEffort
        /// </summary>
        public Effort GetDefaultEffort(ICodeDocsAttribute att)
        {
            return att.Definition.DefaultEffort;
        }

        public Risk GetDefaultMetaRisk(ICodeDocsAttribute att)
        {
            //todo: flush out reasons/rules for risk elevation
            //example:
            //  if (att is BugAttribute && att.Details.Length < 10 && !att.Risk.HasValue && !att.Effort.HasValue)
            //        return Risk.Extreme;

            return Risk.None;
        }

    }
}
