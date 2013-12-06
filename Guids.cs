// Guids.cs
// MUST match guids.h
using System;

namespace Microsoft.LaunchUrlDemo
{
    static class GuidList
    {
        public const string guidLaunchUrlDemoPkgString = "80c5a67b-1962-48ed-9f92-cdf5491bb601";
        public const string guidLaunchUrlDemoCmdSetString = "b283fc7e-af43-46f3-86af-15cedfc7cbd8";
        public const string guidToolWindowPersistanceString = "f8474055-ebe7-4608-a14e-4675e07c589f";

        public static readonly Guid guidLaunchUrlDemoCmdSet = new Guid(guidLaunchUrlDemoCmdSetString);
    };
}