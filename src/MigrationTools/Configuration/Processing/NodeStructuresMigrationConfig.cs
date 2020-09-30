﻿using System;
using System.Collections.Generic;

namespace MigrationTools.Configuration.Processing
{
    public class NodeStructuresMigrationConfig : IProcessorConfig
    {
        public bool PrefixProjectToNodes { get; set; }
        /// <inheritdoc />
        public bool Enabled { get; set; }
        public string[] BasePaths { get; set; }
        /// <inheritdoc />
        public string Processor
        {
            get { return "NodeStructuresMigrationContext"; }
        }                         
        /// <inheritdoc />
        public bool IsProcessorCompatible(IReadOnlyList<IProcessorConfig> otherProcessors)
        {
            return true;
        }
    }
}