using System;
using System.Collections.Generic;

namespace Greenicicle.TfsTimeline.Models
{
    public interface IBuildService
    {
        IEnumerable<BuildInformation> GetBuilds(string projectName, string buildDefinition, DateTime minimumTimeFinished);

        IEnumerable<string> GetProjects();

        IEnumerable<string> GetBuildDefinitions(string projectName);
    }
}