﻿namespace ValidationGroups
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Default : Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                this.Page.Validate("Login");
                if (this.Page.IsValid)
                {
                    this.Group1.Text = "Valid Registration Info";
                }

                this.Page.Validate("PersonalInfo");
                if (this.Page.IsValid)
                {
                    this.Group2.Text = "Valid Personal Info";
                }

                this.Page.Validate("AddressInfo");
                if (this.Page.IsValid)
                {
                    this.Group3.Text = "Valid Address Info";
                }
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.Page.Validate("Login");
            if (this.Page.IsValid)
            {
                this.Group1.Text = "Valid Registration Info";
            }

            this.Page.Validate("PersonalInfo");
            if (this.Page.IsValid)
            {
                this.Group2.Text = "Valid Personal Info";
            }

            this.Page.Validate("AddressInfo");
            if (this.Page.IsValid)
            {
                this.Group3.Text = "Valid Address Info";
            }
        }

        protected void CheckBoxRequired_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = this.RequiredTickValidator.Checked;
        }
    }
}