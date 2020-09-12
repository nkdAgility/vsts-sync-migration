﻿using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.WorkerService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MigrationTools.Core;
using MigrationTools.Core.Configuration;
using MigrationTools.Core.Sinks;
using Serilog;
using Serilog.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MigrationTools
{
    public class MigrationEngine
    {
        private readonly IHost _Host;
        private readonly ILogger<MigrationEngine> _Log;
        private readonly TelemetryClient _Telemetry;
        private readonly EngineConfiguration _Config;

        public MigrationEngine(IHost host, ILogger<MigrationEngine> log, TelemetryClient telemetry, IEngineConfigurationBuilder configBuilder)
        {
            _Host = host;
            _Log = log;
            _Telemetry = telemetry;
            _Config = configBuilder.BuildFromFile();
        }

        public void Run()
        {
            Log.Error("Running but no implementation :) ");
        }
        
    }
}
