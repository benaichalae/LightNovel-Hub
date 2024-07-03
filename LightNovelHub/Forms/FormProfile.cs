using System;
using System.Windows.Forms;

namespace LightNovelHub.Forms
{
    public partial class FormProfile : Form
    {
        private Form2 parentForm;

        public FormProfile(Form2 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
    }
}
