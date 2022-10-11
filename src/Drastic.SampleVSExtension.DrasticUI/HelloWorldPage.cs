// <copyright file="HelloWorldPage.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using Drastic.UI;

namespace Drastic.SampleVSExtension.DrasticUI
{
    public class HelloWorldPage : ContentPage
    {
        public HelloWorldPage()
        {
            this.Content = new Label() { Text = "Hello World!", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
        }
    }
}