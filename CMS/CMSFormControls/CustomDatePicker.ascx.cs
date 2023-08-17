using CMS.Base;
using CMS.FormEngine.Web.UI;
using CMS.Helpers;
using CMS.Localization;
using System;
using System.Web.UI.DataVisualization.Charting;

namespace CMSApp.CMSFormControls
{
    public partial class CustomDatePicker : FormEngineUserControl
    {
        
        public override object Value
        {
            get
            {
                if (!string.IsNullOrEmpty(datePicker.Text))
                {
                    string dateTime = datePicker.Text;                    
                    return DateTime.Parse(dateTime);
                }
                
                return datePicker.Text;                
            }                
            set
            {
                if (value != null)
                {
                   DateTime dateTime = DateTime.Parse(value.ToString());
                   datePicker.Text = dateTime.ToString("yyyy/MM/dd HH:mm");                    
                }
            }
        }
           
        public override bool IsValid()
        { 
            if (string.IsNullOrEmpty(datePicker.Text.ToString()))
            {
                // Sets the form control validation error message
                this.ValidationError = "Please select a Date.";
                return false;               
            }
            else
            {                
                return true;
            }
        }
        public int SelectorWidth
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("SelectorWidth"), 0);
            }
            set
            {
                SetValue("SelectorWidth", value);
            }
        }

        protected void EnsureItems()
        {
            // Applies the width specified through the parameter of the form control if it is valid
            if (SelectorWidth > 0)
            {
                datePicker.Width = SelectorWidth;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                EnsureItems();
            }
        }

    }
}