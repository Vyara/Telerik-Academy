namespace Cars
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    using Utils;

    public partial class CarSearch : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.ViewState["producersLoaded"] == null)
            {
                this.ProducersList.DataSource = Initializer.Producers;
                this.ProducersList.DataBind();
                this.ViewState.Add("producersLoaded", true);

                this.ExtrasCheckBoxList.DataSource = Initializer.Extras;
                this.ExtrasCheckBoxList.DataBind();

                this.EngineTypesRadioList.DataSource = Initializer.EngineTypes;
                this.EngineTypesRadioList.DataBind();
            }
        }

        protected void ProducersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProducer = (from n in Initializer.Producers
                                    where n.Name == this.ProducersList.SelectedValue
                                    select n)
                               .FirstOrDefault();
            if (selectedProducer != null)
            {
                this.ModelsList.DataSource = selectedProducer.Models;
                this.ModelsList.DataBind();
            }
            else
            {
                this.ModelsList.DataSource = new string[] { };
                this.ModelsList.DataBind();
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var html = new HtmlGenericControl("DIV");
            html.Attributes.Add("class", "well");
            var breakLine = "<br/>";
            var producer = "<h4>Producer: </h4>";
            var model = "<h4>Model: </h4>";
            var extras = "<h4>Extras: </h4>";
            var engine = "<h4>Engine: </h4>";
            html.InnerHtml += "<h3>Result:</h3> ";
            html.InnerHtml += producer + ProducersList.SelectedValue + breakLine;
            html.InnerHtml += model + ModelsList.SelectedValue + breakLine;
            html.InnerHtml += extras;

            foreach (ListItem item in ExtrasCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    html.InnerHtml += item + breakLine;
                }
            }

            html.InnerHtml += engine + EngineTypesRadioList.SelectedValue + breakLine;

            this.ShowSubmitted.Text = html.InnerText;
        }
    }
}