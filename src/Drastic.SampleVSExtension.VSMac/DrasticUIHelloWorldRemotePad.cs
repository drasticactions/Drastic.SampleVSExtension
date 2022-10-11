// <copyright file="DrasticUIHelloWorldRemotePad.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using Drastic.SampleVSExtension.DrasticUI;
using Drastic.UI;
using Drastic.UI.Platform.MacOS;
using MonoDevelop.Components;
using MonoDevelop.Ide.Gui;

namespace Drastic.SampleVSExtension.VSMac
{
    public class DrasticUIHelloWorldRemotePad : PadContent
    {
        private NSView content;

        public override Control Control => content;

        public DrasticUIHelloWorldRemotePad()
        {
            var test2 = new HelloWorldPage();
            this.content = test2.CreateViewController().View;
        }
    }
}