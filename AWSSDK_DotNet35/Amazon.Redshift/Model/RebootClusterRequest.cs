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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RebootCluster operation.
    /// <para> Reboots a cluster. This action is taken as soon as possible. It results in a momentary outage to the cluster, during which the
    /// cluster status is set to <c>rebooting</c> . A cluster event is created when the reboot is completed. Any pending cluster modifications (see
    /// ModifyCluster) are applied at this reboot. For more information about managing clusters, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
    /// Management Guide</i> </para>
    /// </summary>
    public partial class RebootClusterRequest : AmazonWebServiceRequest
    {
        private string clusterIdentifier;

        /// <summary>
        /// The cluster identifier.
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

    }
}
    