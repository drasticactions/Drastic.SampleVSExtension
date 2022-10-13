using Drastic.SampleVSExtension.DrasticUI;
using Microsoft.VisualStudio.Shell;
using Drastic.UI;
using Drastic.UI.Platform;
using System;
using System.Runtime.InteropServices;
using Drastic.UI.Platform.WPF.Extensions;

namespace Drastic.SampleVSExtension.Vsix
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("a698897e-f541-450c-8e26-670a7bf2b01b")]
    public class HelloWorldWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HelloWorldWindow"/> class.
        /// </summary>
        public HelloWorldWindow() : base(null)
        {
            var page = new HelloWorldPage();
            this.Caption = "HelloWorldWindow";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = page.ToFrameworkElement();
        }
    }
}
