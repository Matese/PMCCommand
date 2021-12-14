// Copyright (c) 2017 Benjamin Trent. All rights reserved. See LICENSE file in project root

namespace PMCCommand
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Copied wholesale from: https://msdn.microsoft.com/en-us/library/ms228772.aspx.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Copied wholesale from: https://msdn.microsoft.com/en-us/library/ms228772.aspx.")]
    [ComImport]
    [Guid("00000016-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IOleMessageFilter
    {
        [PreserveSig]
        int HandleInComingCall(
            int dwCallType,
            IntPtr hTaskCaller,
            int dwTickCount,
            IntPtr lpInterfaceInfo);

        [PreserveSig]
        int RetryRejectedCall(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwRejectType);

        [PreserveSig]
        int MessagePending(
            IntPtr hTaskCallee,
            int dwTickCount,
            int dwPendingType);
    }
}
