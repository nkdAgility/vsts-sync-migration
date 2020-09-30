﻿using System;
using System.Collections.Generic;
using System.Text;
using MigrationTools.Clients;
using MigrationTools.Engine.Containers;

namespace MigrationTools
{
    public interface IMigrationEngine
    {
        ProcessingStatus Run();
        IMigrationClient Source { get;  }

        IMigrationClient Target { get;  }

        ProcessorContainer Processors { get; }
        TypeDefinitionMapContainer TypeDefinitionMaps { get; }
        GitRepoMapContainer GitRepoMaps { get; }
        ChangeSetMappingContainer ChangeSetMapps { get; }
        FieldMapContainer FieldMaps { get; }
    }
}
