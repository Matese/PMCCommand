﻿// Copyright (c) 2017 Benjamin Trent. All rights reserved. See LICENSE file in project root

namespace PMCCommand
{
    /// <summary>
    /// The collection of command GUIDs and IDs
    /// These were gathered through https://msdn.microsoft.com/en-us/library/cc826040.aspx and https://github.com/mono/nuget/tree/master/src/VsConsole/Console.
    /// </summary>
    public static class GuidsAndIds
    {
#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string GuidStdCommandSet2K = "{1496A755-94DE-11D0-8C3F-00C04FC2AAE2}";
        public const string GuidNuGetConsoleCmdSet = "{1E8A55F6-C18D-407F-91C8-94B02AE1CED6}";
        public const int CmdidOutputPaneCombo = 1627;
        public const int CmdidNuGetSources = 1024;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore SA1600 // Elements should be documented
    }
}
