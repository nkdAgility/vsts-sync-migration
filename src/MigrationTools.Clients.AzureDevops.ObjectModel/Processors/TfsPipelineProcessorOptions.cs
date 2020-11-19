﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrationTools.Endpoints;

namespace MigrationTools.Processors
{
    class TfsPipelineProcessorOptions : ProcessorOptions
    {
        /// <summary>
        /// Migrate Build Pipelines
        /// </summary>
        /// <default>true</default>
        public bool MigrateBuildPipelines { get; set; }

        /// <summary>
        /// Migrate Release Pipelines
        /// </summary>
        /// <default>true</default>
        public bool MigrateReleasePipelines { get; set; }

        /// <summary>
        /// List of Build Pipelines to process. If this is `null` then all Build Pipelines will be processed.
        /// </summary>
        public List<string> BuildPipelines { get; set; }

        /// <summary>
        /// List of Release Pipelines to process. If this is `null` then all Release Pipelines will be processed.
        /// </summary>
        public List<string> ReleasePipelines { get; set; }
        public override Type ToConfigure => typeof(TfsPipelineProcessor);

        public override IProcessorOptions GetDefault()
        {
            return this;
        }

        public override void SetDefaults()
        {
            MigrateBuildPipelines = true;
            MigrateReleasePipelines = true;
            BuildPipelines = null;
            ReleasePipelines = null;
            var e1 = new TfsEndpointOptions();
            e1.SetDefaults();
            e1.Project = "sourceProject";
            Source = e1;
            var e2 = new TfsEndpointOptions();
            e2.SetDefaults();
            e2.Project = "targetProject";
            Target = e2;
        }
    }
}