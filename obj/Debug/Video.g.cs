﻿#pragma checksum "..\..\Video.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B8E7DF41FFFD5D3AD9ECC9B3E400D103989713E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyFirstProject2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MyFirstProject2 {
    
    
    /// <summary>
    /// Video
    /// </summary>
    public partial class Video : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backwardsButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forwardButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderback2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Video.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock time;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyFirstProject2;component/video.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Video.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\Video.xaml"
            ((MyFirstProject2.Video)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Video.xaml"
            ((MyFirstProject2.Video)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.media1 = ((System.Windows.Controls.MediaElement)(target));
            
            #line 12 "..\..\Video.xaml"
            this.media1.MediaOpened += new System.Windows.RoutedEventHandler(this.media1_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 4:
            this.playButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Video.xaml"
            this.playButton.Click += new System.Windows.RoutedEventHandler(this.playButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.pauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Video.xaml"
            this.pauseButton.Click += new System.Windows.RoutedEventHandler(this.pauseButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Video.xaml"
            this.stopButton.Click += new System.Windows.RoutedEventHandler(this.stopButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.backwardsButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Video.xaml"
            this.backwardsButton.Click += new System.Windows.RoutedEventHandler(this.backwardsButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.forwardButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Video.xaml"
            this.forwardButton.Click += new System.Windows.RoutedEventHandler(this.forwardButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.slider1 = ((System.Windows.Controls.Slider)(target));
            
            #line 22 "..\..\Video.xaml"
            this.slider1.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider1_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.slider2 = ((System.Windows.Controls.Slider)(target));
            
            #line 23 "..\..\Video.xaml"
            this.slider2.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider2_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.sliderback2 = ((System.Windows.Controls.Slider)(target));
            return;
            case 12:
            this.time = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

