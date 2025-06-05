using HotelPmsCore.Models;
using HotelPmsCore.Services;
using System;
using System.Windows.Forms;

namespace HotelPmsCore.Forms
{
    public partial class PeriodEditForm : Form
    {
        private readonly PeriodService svc;

        public PeriodEditForm(PeriodService svc)
        {
            InitializeComponent();
            this.svc = svc;
            this.bindingSourcePeriod.DataSource = svc.BndSource;

            
            this.textBoxName.DataBindings.Add("Text",this.bindingSourcePeriod,nameof(Models.Period.Name),true,DataSourceUpdateMode.OnPropertyChanged);

            this.dateTimePickerStart.DataBindings.Add("Value",this.bindingSourcePeriod,nameof(Models.Period.StartDate),true,DataSourceUpdateMode.OnPropertyChanged);

            this.dateTimePickerEnd.DataBindings.Add("Value", bindingSourcePeriod,nameof(Models.Period.EndDate),true,DataSourceUpdateMode.OnPropertyChanged);
        }

 

        private void Savebutton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }

    }
}
