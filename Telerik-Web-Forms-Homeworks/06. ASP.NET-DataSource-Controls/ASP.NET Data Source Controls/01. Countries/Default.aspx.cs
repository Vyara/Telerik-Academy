namespace Continents
{
    using System;
    using System.IO;
    using System.Linq;

    public partial class Default : System.Web.UI.Page
    {
        private ContinentsEntities db = new ContinentsEntities();     

        public void TownsListView_InsertItem()
        {
            var town = new Town();
            this.TryUpdateModel(town);
            if (ModelState.IsValid)
            {
                this.db.Towns.Add(town);
                this.db.SaveChanges();
            }
        }

        public void TownsListView_DeleteItem(int id)
        {
            try
            {
                this.db.Towns.Remove(this.db.Towns.Find(id));
                this.db.SaveChanges();
            }
            catch (Exception)
            {
            }
        }

        public void TownsListView_UpdateItem(int id)
        {
            var town = this.db.Towns.Find(id);
            if (town == null)
            {
                this.ModelState.AddModelError(string.Empty, string.Format("Item with id {0} was not found", id));
                return;
            }

            this.TryUpdateModel(town);
            if (ModelState.IsValid)
            {
            }
        }

        protected void InsertCountryBtn_Click(object sender, EventArgs e)
        {
            int population;
            if (!int.TryParse(this.InsertedCountryPopulation.Text, out population))
            {
                population = 5;
            }

            byte[] flag;

            if (this.InsertedCountryFlag.HasFile && this.InsertedCountryFlag.PostedFile.ContentType == "image/png")
            {
                flag = new BinaryReader(this.InsertedCountryFlag.PostedFile.InputStream).ReadBytes(this.InsertedCountryFlag.PostedFile.ContentLength);
            }
            else
            {
                flag = File.ReadAllBytes(Server.MapPath("default.png"));
            }

            var continentId = this.db.Continents.FirstOrDefault().Id;
            if (!string.IsNullOrEmpty(this.ListBoxContinents.SelectedValue))
            {
                continentId = int.Parse(this.ListBoxContinents.SelectedValue);
            }

            this.db.Countries.Add(new Country()
            {
                ContinentId = continentId,
                Language = this.InsertedCountryLanguage.Text ?? "Unspeakable",
                Name = this.InsertedCountryName.Text ?? "Unnammed",
                Population = population,
                FlagImage = flag
            });

            this.db.SaveChanges();

            this.DataBind();
        }

        protected void UpdateContinetBtn_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.ListBoxContinents.SelectedValue);
            var continent = this.db.Continents.FirstOrDefault(c => c.Id == id);
            continent.Name = this.UpdateContinetTb.Text;
            this.UpdateContinetTb.Text = string.Empty;
            this.db.SaveChanges();
            this.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var flag = File.ReadAllBytes(Server.MapPath("default.png"));
            foreach (var item in this.db.Countries)
            {
                item.FlagImage = flag;
            }

            this.db.SaveChanges();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
        }

        protected void ListBoxContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void InsertContinentBtn_Click(object sender, EventArgs e)
        {
            this.db.Continents.Add(new Continent() { Name = this.InsertContinetTb.Text });
            this.db.SaveChanges();
            this.InsertContinetTb.Text = string.Empty;
            this.DataBind();
        }

        protected void DeleteContinetBtn_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.ListBoxContinents.SelectedValue);
            var continent = this.db.Continents.FirstOrDefault(c => c.Id == id);
            this.db.Continents.Remove(continent);
            this.db.SaveChanges();
            this.DataBind();
        }
    }
}