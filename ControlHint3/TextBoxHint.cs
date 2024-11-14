using System;
using System.ComponentModel;
using System.Drawing;
using System.Transactions;
using System.Windows.Forms;

namespace ControlHint3
{
    public partial class TextBoxHint : TextBox
    {
        private string strHint;

        [Category("Hint")]
        [Description("Texto de sugerencia hint como el componente de android.")]

        public string Hint
        {
            get { return strHint; }
            set
            {
                strHint = value;

                if (string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(Hint))
                {
                    this.Text = Hint;
                    this.ForeColor = Color.Gray;
                }
            }
        }

        public TextBoxHint()
        {
            InitializeComponent();
            this.ForeColor = Color.Black;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
           

            if (this.Text == Hint)
            {
                this.Clear();
                this.ForeColor = Color.Black;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            if (string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(Hint))
            {
                this.Text = Hint;
                this.ForeColor = Color.Gray;
            }
        }
    }
}
