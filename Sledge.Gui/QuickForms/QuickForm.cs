﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sledge.Gui.Containers;
using Sledge.Gui.Controls;
using Sledge.Gui.Interfaces;
using Sledge.Gui.Interfaces.Controls;
using Sledge.Gui.Interfaces.Shell;
using Sledge.Gui.QuickForms.Items;
using Sledge.Gui.Shell;

namespace Sledge.Gui.QuickForms
{
    /// <summary>
    /// QuickForms is input dialogs for the lazy.
    /// It allows quick composition of disposable forms.
    /// </summary>
    public sealed class QuickForm : Window
    {
        private VerticalBox _vbox;

        /// <summary>
        /// Change the standard height of each item in the form.
        /// </summary>
        public static int ItemHeight = 20;

        /// <summary>
        /// Change the standard padding between each item in the form.
        /// </summary>
        public static int ItemPadding = 5;

        private readonly List<IQuickFormItem> _items;

        /// <summary>
        /// The current Y offset of the form.
        /// </summary>
        public int CurrentOffset { get; private set; }

        /// <summary>
        /// Get or set the width of item labels. This is not used 
        /// for a Label item, which takes the full width.
        /// </summary>
        public int LabelWidth { get; set; }

        public bool UseShortcutKeys { get; set; }

        public bool Success { get; set; }

        /// <summary>
        /// Create a form with the specified title.
        /// </summary>
        /// <param name="title">The title of the form</param>
        public QuickForm(string title)
        {
            _vbox = new VerticalBox();
            Container.Set(_vbox);

            _items = new List<IQuickFormItem>();
            LabelWidth = 100;
            CurrentOffset = ItemPadding;
            Title = title;
            AutoSize = true;
            // todo FormBorderStyle = FormBorderStyle.FixedDialog;
            // todo ShowInTaskbar = false;
            // todo MinimizeBox = false;
            // todo MaximizeBox = false;
            UseShortcutKeys = false;
            // todo KeyPreview = true;
        }

        // todo quickform hotkeys
        // protected override void OnKeyDown(KeyEventArgs e)
        // {
        //     if (UseShortcutKeys)
        //     {
        //         if (e.KeyCode == Keys.Enter)
        //         {
        //             var ok = Controls.OfType<Button>().FirstOrDefault(x => x.DialogResult == DialogResult.OK || x.DialogResult == DialogResult.Yes);
        //             if (ok != null) ok.PerformClick();
        //         }
        //         else if (e.KeyCode == Keys.Escape)
        //         {
        //             var cancel = Controls.OfType<Button>().FirstOrDefault(x => x.DialogResult == DialogResult.Cancel || x.DialogResult == DialogResult.No);
        //             if (cancel != null) cancel.PerformClick();
        //         }
        //     }
        //     base.OnKeyDown(e);
        // }

        /*
        protected override void OnLoad(EventArgs e)
        {
            ClientSize = new System.Drawing.Size(ClientSize.Width, CurrentOffset + ItemPadding);
            var nonlabel = Controls.OfType<Control>().FirstOrDefault(x => !(x is Label));
            if (nonlabel != null) nonlabel.Focus();
            base.OnLoad(e);
        }*/

        /// <summary>
        /// Add an item to the form.
        /// </summary>
        /// <param name="item">The item to add</param>
        public void AddItem(IQuickFormItem item)
        {
            _items.Add(item);
            var ctl = item.GetControl(this);
            if (ctl != null) _vbox.Add(ctl);
            CurrentOffset += ItemHeight + ItemPadding;
        }

        /// <summary>
        /// Add an item to the form.
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <returns>This object, for method chaining</returns>
        public QuickForm Item(IQuickFormItem item)
        {
            AddItem(item);
            return this;
        }

        /// <summary>
        /// Add a textbox to the form.
        /// </summary>
        /// <param name="name">The name of the textbox</param>
        /// <param name="value">The default value of the textbox</param>
        /// <returns>This object, for method chaining</returns>
        public QuickForm TextBox(string name, string value = "")
        {
            AddItem(new QuickFormTextBox(name, value));
            return this;
        }

        /// <summary>
        /// Add a browse textbox to the form.
        /// </summary>
        /// <param name="name">The name of the textbox</param>
        /// <param name="filter">The filter for the open file dialog</param>
        /// <returns>This object, for method chaining</returns>
        // public QuickForm Browse(string name, string filter)
        // {
        //     AddItem(new QuickFormBrowse(name, filter));
        //     return this;
        // }

        /// <summary>
        /// Add a label to the form.
        /// </summary>
        /// <param name="text">The text of the label</param>
        /// <returns>This object, for method chaining</returns>
        public QuickForm Label(string text)
        {
            AddItem(new QuickFormLabel(text));
            return this;
        }

        /// <summary>
        /// Add a NumericUpDown to the form.
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <param name="min">The minimum value of the control</param>
        /// <param name="max">The maximum value of the control</param>
        /// <param name="decimals">The number of decimals for the control</param>
        /// <param name="value">The default value of the control</param>
        /// <returns>This object, for method chaining</returns>
        // public QuickForm NumericUpDown(string name, int min, int max, int decimals, decimal value = 0)
        // {
        //     AddItem(new QuickFormNumericUpDown(name, min, max, decimals, value));
        //     return this;
        // }

        /// <summary>
        /// Add a ComboBox to the form.
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <param name="items">The items for the control</param>
        /// <returns>This object, for method chaining</returns>
        // public QuickForm ComboBox(string name, IEnumerable<object> items)
        // {
        //     AddItem(new QuickFormComboBox(name, items));
        //     return this;
        // }

        /// <summary>
        /// Add a checkbox to the form.
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <param name="value">The initial value of the checkbox</param>
        /// <returns>This object, for method chaining</returns>
        // public QuickForm CheckBox(string name, bool value = false)
        // {
        //     AddItem(new QuickFormCheckBox(name, value));
        //     return this;
        // }

        /// <summary>
        /// Add OK and Cancel buttons to the control
        /// </summary>
        /// <param name="ok">The action to perform when OK is clicked</param>
        /// <param name="cancel">The action to perform when cancel is clicked</param>
        /// <returns>This object, for method chaining</returns>
        public QuickForm OkCancel(Action<QuickForm> ok = null, Action<QuickForm> cancel = null)
        {
            AddItem(new QuickFormOkCancel(ok, cancel));
            return this;
        }

        /// <summary>
        /// Add a button to the control
        /// </summary>
        /// <param name="text">The button text</param>
        /// <param name="action">The action to perform when the button is clicked</param>
        /// <returns>This object, for method chaining</returns>
        // public QuickForm Button(string text, Action action)
        // {
        //     AddItem(new QuickFormButton(text, action));
        //     return this;
        // }

        public void Close(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Get a control by name
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <returns>The control, or null if it was not found</returns>
        public IControl GetControl(string name)
        {
            return FindControl(name, _vbox);
        }

        private IControl FindControl(string name, IContainer parent)
        {
            var ctrl = parent.Children.FirstOrDefault(x => x.BindingSource == name); // todo IControl.Name
            if (ctrl == null)
            {
                foreach (var container in parent.Children.OfType<IContainer>())
                {
                    ctrl = FindControl(name, container);
                    if (ctrl != null) break;
                }
            }
            return ctrl;
        }

        /// <summary>
        /// Get a string value from a control
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <returns>The string value</returns>
        public string String(string name)
        {
            var c = GetControl(name) as ITextControl;
            if (c != null) return c.Text;
            throw new Exception("Control " + name + " not found!");
        }

        /* todo numeric control
        /// <summary>
        /// Get a decimal value from a control
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <returns>The decimal value</returns>
        public decimal Decimal(string name)
        {
            var c = GetControl(name);
            if (c != null) return ((NumericUpDown)c).Value;
            throw new Exception("Control " + name + " not found!");
        }
         */

        /// <summary>
        /// Get a boolean value from a control
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <returns>The boolean value</returns>
        public bool Bool(string name)
        {
            var c = GetControl(name);
            if (c != null) return ((CheckBox)c).Checked;
            throw new Exception("Control " + name + " not found!");
        }

        /// <summary>
        /// Get an object from a control
        /// </summary>
        /// <param name="name">The name of the control</param>
        /// <returns>The object</returns>
        public object Object(string name)
        {
            var c = GetControl(name);
            if (c != null) return ((ComboBox)c).SelectedItem;
            throw new Exception("Control " + name + " not found!");
        }
    }
}
