using HotelPmsCore.Models;

namespace HotelPmsCore.Forms
{
    partial class CategoryEditForm
    {
      
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public class InnerCategoryEditForm : Form
        {
            private TypedCategory _entity;

            public InnerCategoryEditForm(TypedCategory entity)
            {
                _entity = entity;
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                // enter code
            }
        }
    }
}