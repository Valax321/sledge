﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sledge.DataStructures.Geometric;
using Sledge.Editor.Enums;

namespace Sledge.Editor.UI
{
    public partial class TransformDialog : Form
    {
        private readonly Box _source;

        public Coordinate TransformValue
        {
            get { return new Coordinate(ValueX.Value, ValueY.Value, ValueZ.Value); }
            set
            {
                ValueX.Value = value.X;
                ValueY.Value = value.Y;
                ValueZ.Value = value.Z;
            }
        }

        public TransformType TransformType
        {
            get
            {
                if (Rotate.Checked) return TransformType.Rotate;
                if (Scale.Checked) return TransformType.Scale;
                return TransformType.Translate;
            }
            set
            {
                switch (value)
                {
                    case TransformType.Rotate:
                        Rotate.Checked = true;
                        break;
                    case TransformType.Scale:
                        Scale.Checked = true;
                        break;
                    default:
                        Translate.Checked = true;
                        break;
                }
            }
        }

        public TransformDialog(Box source)
        {
            _source = source;
            InitializeComponent();

            ZeroValueXButton.Click += (sender, e) => ValueX.Value = 0;
            ZeroValueYButton.Click += (sender, e) => ValueY.Value = 0;
            ZeroValueZButton.Click += (sender, e) => ValueZ.Value = 0;

            SourceValueXButton.Click += (sender, e) => ValueX.Value = _source.Width;
            SourceValueYButton.Click += (sender, e) => ValueY.Value = _source.Length;
            SourceValueZButton.Click += (sender, e) => ValueZ.Value = _source.Height;

            TypeChanged(null, null);
        }

        private void TypeChanged(object sender, EventArgs e)
        {
            SourceValueXButton.Visible
                = SourceValueYButton.Visible
                  = SourceValueZButton.Visible
                    = Translate.Checked;
        }
    }
}
