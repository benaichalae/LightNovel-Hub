using System;
using System.Windows.Forms;

namespace LightNovelHub.Forms
{
    public partial class FormAboutUs : Form
    {
        private Form2 parentForm;

        public FormAboutUs(Form2 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
    }
}
