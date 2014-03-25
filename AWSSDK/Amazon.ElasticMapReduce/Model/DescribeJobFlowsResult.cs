/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para> The output for the DescribeJobFlows operation. </para>
    /// </summary>
    public class DescribeJobFlowsResult
    {
        
        private List<JobFlowDetail> jobFlows = new List<JobFlowDetail>();

        /// <summary>
        /// A list of job flows matching the parameters supplied.
        ///  
        /// </summary>
        public List<JobFlowDetail> JobFlows
        {
            get { return this.jobFlows; }
            set { this.jobFlows = value; }
        }
        /// <summary>
        /// Adds elements to the JobFlows collection
        /// </summary>
        /// <param name="jobFlows">The values to add to the JobFlows collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsResult WithJobFlows(params JobFlowDetail[] jobFlows)
        {
            foreach (JobFlowDetail element in jobFlows)
            {
                this.jobFlows.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the JobFlows collection
        /// </summary>
        /// <param name="jobFlows">The values to add to the JobFlows collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsResult WithJobFlows(IEnumerable<JobFlowDetail> jobFlows)
        {
            foreach (JobFlowDetail element in jobFlows)
            {
                this.jobFlows.Add(element);
            }

            return this;
        }

        // Check to see if JobFlows property is set
        internal bool IsSetJobFlows()
        {
            return this.jobFlows.Count > 0;
        }
    }
}