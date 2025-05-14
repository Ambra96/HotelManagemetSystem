using System;
using System.Windows.Forms;
using HotelPmsCore.Models;

namespace HotelPmsCore.Forms
{
    partial class CategoryEditForm : Form
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
            private TypedCategory entity;

            public InnerCategoryEditForm(TypedCategory entity)
            {
                this.entity = entity;
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                //code edw
            }
        }
    }
}
