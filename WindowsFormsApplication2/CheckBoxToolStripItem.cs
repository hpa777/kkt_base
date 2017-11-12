using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class CheckBoxToolStripItem : ToolStripControlHost
    {
        private FlowLayoutPanel controlPanel;
        private System.Windows.Forms.CheckBox chk = new System.Windows.Forms.CheckBox();

        public CheckBoxToolStripItem()
            : base(new FlowLayoutPanel())
        {
            // Set up the FlowLayouPanel.
            controlPanel = (FlowLayoutPanel)base.Control;
            controlPanel.BackColor = Color.Transparent;

            // Add two child controls.
            chk.AutoSize = true;
            controlPanel.Controls.Add(chk);

        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            chk.CheckedChanged += new EventHandler(CheckedChanged);
        }

        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            chk.CheckedChanged -= new EventHandler(CheckedChanged);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable the TextBox according to the
            // current CheckBox selection.
            //txt.Enabled = TextEnabled;
            if (OnChecked != null)
            {
                OnChecked(chk, evargs);
            }
        }

        public event EventHandler OnChecked;

        private EventArgs evargs = new EventArgs();


    }
}
