﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sledge.Gui.Controls;
using Sledge.Gui.Events;
using Sledge.Gui.Interfaces.Containers;
using Sledge.Gui.Interfaces.Shell;

namespace Sledge.Gui.Shell
{
    public class Window : ControlBase<IWindow>, IWindow
    {
        protected override IWindow CreateControl()
        {
            return UIManager.Manager.CreateWindow();
        }

        public string Title
        {
            get { return Control.Title; }
            set { Control.Title = value; }
        }

        public bool AutoSize
        {
            get { return Control.AutoSize; }
            set { Control.AutoSize = value; }
        }

        public ICell Container
        {
            get { return Control.Container; }
        }

        public void Open()
        {
            Control.Open();
        }

        public void Close()
        {
            Control.Close();
        }

        public event EventHandler WindowLoaded
        {
            add { Control.WindowLoaded += value; }
            remove { Control.WindowLoaded -= value; }
        }

        public event EventHandler<HandledEventArgs> WindowClosing
        {
            add { Control.WindowClosing += value; }
            remove { Control.WindowClosing -= value; }
        }

        public event EventHandler WindowClosed
        {
            add { Control.WindowClosed += value; }
            remove { Control.WindowClosed -= value; }
        }
    }
}
