// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable CS1591, CS1573, CS0649, CS8019, CS1570, CS1584, CS1658
namespace Microsoft.Windows.Sdk
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.InteropServices;

    /// <content>
    /// Contains extern methods into "Shell32.dll".
    /// </content>
    internal static partial class PInvoke
    {
        /// <inheritdoc cref = "SHAppBarMessage(uint, APPBARDATA*)"/>
        internal static unsafe nuint SHAppBarMessage(uint dwMessage, ref APPBARDATA pData)
        {
            fixed (APPBARDATA*pDataLocal = &pData)
            {
                return PInvoke.SHAppBarMessage(dwMessage, pDataLocal);
            }
        }

        /// <summary>Sends an appbar message to the system.</summary>
        /// <param name = "dwMessage">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>Appbar message value to send. This parameter can be one of the following values.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shappbarmessage#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "pData">
        /// <para>Type: <b>PAPPBARDATA</b></para>
        /// <para>A pointer to an <a href = "https://docs.microsoft.com/windows/desktop/api/shellapi/ns-shellapi-appbardata">APPBARDATA</a> structure. The content of the structure on entry and on exit depends on the value set in the <i>dwMessage</i> parameter. See the individual message pages for specifics.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shappbarmessage#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>UINT_PTR</b></para>
        /// <para>This function returns a message-dependent value. For more information, see the Windows SDK documentation for the specific appbar message sent. Links to those documents are given in the See Also section.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shappbarmessage">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Shell32", ExactSpelling = true)]
        internal static extern unsafe nuint SHAppBarMessage(uint dwMessage, [In, Out] APPBARDATA*pData);
        /// <inheritdoc cref = "Shell_NotifyIcon(uint, NOTIFYICONDATAW*)"/>
        internal static unsafe bool Shell_NotifyIcon(uint dwMessage, in NOTIFYICONDATAW lpData)
        {
            fixed (NOTIFYICONDATAW*lpDataLocal = &lpData)
            {
                return PInvoke.Shell_NotifyIcon(dwMessage, lpDataLocal);
            }
        }

        /// <summary>Sends a message to the taskbar's status area.</summary>
        /// <param name = "dwMessage">
        /// <para>Type: <b>DWORD</b></para>
        /// <para>A value that specifies the action to be taken by this function. It can have one of the following values:</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shell_notifyiconw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <param name = "lpData">
        /// <para>Type: <b>PNOTIFYICONDATA</b></para>
        /// <para>A pointer to a <a href = "https://docs.microsoft.com/windows/desktop/api/shellapi/ns-shellapi-notifyicondataa">NOTIFYICONDATA</a> structure. The content of the structure depends on the value of <i>dwMessage</i>. It can define an icon to add to the notification area, cause that icon to display a notification, or identify an icon to modify or delete.</para>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shell_notifyiconw#parameters">Read more on docs.microsoft.com</see>.</para>
        /// </param>
        /// <returns>
        /// <para>Type: <b>BOOL</b></para>
        /// <para>Returns <b>TRUE</b> if successful, or <b>FALSE</b> otherwise. If <i>dwMessage</i> is set to NIM_SETVERSION, the function returns <b>TRUE</b> if the version was successfully changed, or <b>FALSE</b> if the requested version is not supported.</para>
        /// </returns>
        /// <remarks>
        /// <para><see href = "https://docs.microsoft.com/windows/win32/api//shellapi/nf-shellapi-shell_notifyiconw">Learn more about this API from docs.microsoft.com</see>.</para>
        /// </remarks>
        [DllImport("Shell32", ExactSpelling = true, EntryPoint = "Shell_NotifyIconW")]
        internal static extern unsafe bool Shell_NotifyIcon(uint dwMessage, [In] NOTIFYICONDATAW*lpData);
    }
}