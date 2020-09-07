﻿using System;
using AzureDevOpsMigrationTools.Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _VstsSyncMigrator.Engine.Tests
{
    [TestClass]
    public class EngineConfigurationTests
    {
        [TestMethod]
        public void EngineConfigurationCreate()
        {
            EngineConfiguration ec = new EngineConfiguration();
            ec.TelemetryEnableTrace = true;
            ec.Source = new TeamProjectConfig() { Project = "DemoProjs", Collection = new Uri("https://sdd2016.visualstudio.com/"), ReflectedWorkItemIDFieldName = "TfsMigrationTool.ReflectedWorkItemId", PersonalAccessToken="" };
            ec.Target = new TeamProjectConfig() { Project = "DemoProjt", Collection = new Uri("https://sdd2016.visualstudio.com/"), ReflectedWorkItemIDFieldName = "TfsMigrationTool.ReflectedWorkItemId", PersonalAccessToken = "" };
            Assert.IsNotNull(ec);
            Assert.IsNotNull(ec.Source);
            Assert.AreEqual(ec.Source.Project, "DemoProjs");
        }

        [TestMethod]
        public void EngineConfigurationCreateDefault()
        {
            EngineConfiguration ec = EngineConfiguration.GetDefault();
            Assert.IsNotNull(ec);
            Assert.IsNotNull(ec.Source);
            Assert.AreEqual(ec.Source.Project, "migrationSource1");
        }
    }
}
