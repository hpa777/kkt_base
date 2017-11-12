using System;

namespace WindowsFormsApplication2
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public object bindingSource;
        public Type itemType;

        public override string ToString()
        {
            return Text;
        }
        public ComboboxItem(string text, object value)
        {
            this.Text = text;
            this.Value = value;
        }
    }
}
