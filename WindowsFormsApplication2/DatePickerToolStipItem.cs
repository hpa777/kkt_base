using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class DatePickerToolStipItem : ToolStripControlHost
    {
        private FlowLayoutPanel controlPanel;
        private DateTimePicker picer = new DateTimePicker();

        public DatePickerToolStipItem()
            : base(new FlowLayoutPanel())
        {
            controlPanel = (FlowLayoutPanel)base.Control;
            controlPanel.BackColor = Color.Transparent;
            controlPanel.Controls.Add(picer);
        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            picer.ValueChanged += new EventHandler(picer_ValueChanged);
        }

        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            picer.ValueChanged -= new EventHandler(picer_ValueChanged);
        }

        void picer_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


    }
}
