using Sledge.Common.Translations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sledge.BspEditor.Environment.Source
{
    public partial class MaterialExclusionDialog : Form
    {
        private Action<string> _acceptFunc;

        public MaterialExclusionDialog(Action<string> acceptFunc)
        {
            InitializeComponent();
            _acceptFunc = acceptFunc;
        }

        public void Translate(ITranslationStringProvider strings)
        {
            var prefix = GetType().FullName;

            Text = strings.GetString(prefix, "Title");
            lblInstructions.Text = strings.GetString(prefix, "Instructions");
            btnOk.Text = strings.GetString(prefix, "OK");
            btnCancel.Text = strings.GetString(prefix, "Cancel");
        }

        private void Accept(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExclusion.Text))
                return;

            if (_acceptFunc != null)
            {
                _acceptFunc.Invoke(txtExclusion.Text);
            }

            Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
