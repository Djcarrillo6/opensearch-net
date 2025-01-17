/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*   http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
//      *NIX        :   ./build.sh codegen
//      Windows     :   build.bat codegen
//
// -----------------------------------------------
namespace OpenSearch.Client
{
    internal static partial class ApiUrlsLookups
    {
        internal static readonly ApiUrls DanglingIndicesDeleteDanglingIndex =
            new(new[] { "_dangling/{index_uuid}" });

        internal static readonly ApiUrls DanglingIndicesImportDanglingIndex =
            new(new[] { "_dangling/{index_uuid}" });

        internal static readonly ApiUrls DanglingIndicesList = new(new[] { "_dangling" });

        internal static readonly ApiUrls IngestDeletePipeline =
            new(new[] { "_ingest/pipeline/{id}" });

        internal static readonly ApiUrls IngestGetPipeline =
            new(new[] { "_ingest/pipeline", "_ingest/pipeline/{id}" });

        internal static readonly ApiUrls IngestGrokProcessorPatterns =
            new(new[] { "_ingest/processor/grok" });

        internal static readonly ApiUrls IngestPutPipeline = new(new[] { "_ingest/pipeline/{id}" });

        internal static readonly ApiUrls IngestSimulatePipeline =
            new(new[] { "_ingest/pipeline/_simulate", "_ingest/pipeline/{id}/_simulate" });

        internal static readonly ApiUrls NodesHotThreads =
            new(new[] { "_nodes/hot_threads", "_nodes/{node_id}/hot_threads" });

        internal static readonly ApiUrls NodesInfo =
            new(
                new[]
                {
                    "_nodes",
                    "_nodes/{node_id}",
                    "_nodes/{metric}",
                    "_nodes/{node_id}/{metric}"
                }
            );

        internal static readonly ApiUrls NodesReloadSecureSettings =
            new(
                new[] { "_nodes/reload_secure_settings", "_nodes/{node_id}/reload_secure_settings" }
            );

        internal static readonly ApiUrls NodesStats =
            new(
                new[]
                {
                    "_nodes/stats",
                    "_nodes/stats/{metric}",
                    "_nodes/stats/{metric}/{index_metric}",
                    "_nodes/{node_id}/stats",
                    "_nodes/{node_id}/stats/{metric}",
                    "_nodes/{node_id}/stats/{metric}/{index_metric}"
                }
            );

        internal static readonly ApiUrls NodesUsage =
            new(
                new[]
                {
                    "_nodes/usage",
                    "_nodes/usage/{metric}",
                    "_nodes/{node_id}/usage",
                    "_nodes/{node_id}/usage/{metric}"
                }
            );

        internal static readonly ApiUrls SnapshotCleanupRepository =
            new(new[] { "_snapshot/{repository}/_cleanup" });

        internal static readonly ApiUrls SnapshotClone =
            new(new[] { "_snapshot/{repository}/{snapshot}/_clone/{target_snapshot}" });

        internal static readonly ApiUrls SnapshotSnapshot =
            new(new[] { "_snapshot/{repository}/{snapshot}" });

        internal static readonly ApiUrls SnapshotCreateRepository =
            new(new[] { "_snapshot/{repository}" });

        internal static readonly ApiUrls SnapshotDelete =
            new(new[] { "_snapshot/{repository}/{snapshot}" });

        internal static readonly ApiUrls SnapshotDeleteRepository =
            new(new[] { "_snapshot/{repository}" });

        internal static readonly ApiUrls SnapshotGet =
            new(new[] { "_snapshot/{repository}/{snapshot}" });

        internal static readonly ApiUrls SnapshotGetRepository =
            new(new[] { "_snapshot", "_snapshot/{repository}" });

        internal static readonly ApiUrls SnapshotRestore =
            new(new[] { "_snapshot/{repository}/{snapshot}/_restore" });

        internal static readonly ApiUrls SnapshotStatus =
            new(
                new[]
                {
                    "_snapshot/_status",
                    "_snapshot/{repository}/_status",
                    "_snapshot/{repository}/{snapshot}/_status"
                }
            );

        internal static readonly ApiUrls SnapshotVerifyRepository =
            new(new[] { "_snapshot/{repository}/_verify" });

        internal static readonly ApiUrls TasksCancel =
            new(new[] { "_tasks/_cancel", "_tasks/{task_id}/_cancel" });

        internal static readonly ApiUrls TasksGetTask = new(new[] { "_tasks/{task_id}" });

        internal static readonly ApiUrls TasksList = new(new[] { "_tasks" });
    }
}
