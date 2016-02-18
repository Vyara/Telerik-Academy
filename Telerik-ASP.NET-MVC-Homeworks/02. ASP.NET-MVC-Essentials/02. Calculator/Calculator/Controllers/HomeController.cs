namespace Calculator.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models.CalculatorModels;

    public class HomeController : Controller
    {
        public HomeController()
        {
            this.Units = new List<string>()
            {
                "bit - b",
                "Byte - B",
                "Kilobit - Kb",
                "Kilobyte - KB",
                "Megabit - Mb",
                "Megabyte - MB",
                "Gigabit - Gb",
                "Gigabyte - GB",
                "Terabit - Tb",
                "Terabyte - TB",
                "Petabit - Pb",
                "Petabyte - PB",
                "Exabit - Eb",
                "Exabyte - EB",
                "Zettabit - Zb",
                "Zettabyte - ZB",
                "Yottabit - Yb",
                "Yottabyte - YB"
            };

            this.Names = new List<string>()
            {
                "Bit",
                "Byte",
                "Kilobit",
                "Kilobyte",
                "Megabit",
                "Megabyte",
                "Gigabit",
                "Gigabyte",
                "Terabit",
                "Terabyte",
                "Petabit",
                "Petabyte",
                "Exabit",
                "Exabyte",
                "Zettabit",
                "Zettabyte",
                "Yottabit",
                "Yottabyte"
            };

            this.UnitItems = new List<SelectListItem>();
            foreach (var unit in this.Units)
            {
                this.UnitItems.Add(new SelectListItem()
                {
                    Text = unit,
                    Value = unit
                });
            }

            this.Kilo = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "1024", Value = "1024"},
                new SelectListItem() {Text = "1000", Value = "1000"}
            };
        }

        public List<string> Units { get; set; }

        public List<string> Names { get; set; }

        public List<SelectListItem> UnitItems { get; set; }

        public List<SelectListItem> Kilo { get; set; }

        private void InitializeDataNames(List<Data> results)
        {
            for (int i = 0; i < this.Names.Count; i++)
            {
                results.Add(new Data()
                {
                    Name = this.Names[i]
                });
            }
        }


        [HttpGet]
        public ActionResult Index()
        {
            this.ViewBag.Units = this.UnitItems;
            this.ViewBag.Kilo = this.Kilo;

            return View();
        }

        //logic could be moved to a service, but since I won't be creating a db here and it is not so much, I'll write it in the controller
        [HttpPost]
        public ActionResult Index(string amount, string units, string kilo)
        {
            ViewBag.Qunatity = amount;

            var unitType = this.UnitItems.Single(x => x.Value == units);
            unitType.Selected = true;
            this.ViewBag.Units = this.UnitItems;
            var kiloType = this.Kilo.Single(x => x.Value == kilo);
            kiloType.Selected = true;
            this.ViewBag.Kilo = this.Kilo;

            List<Data> results = new List<Data>(this.UnitItems.Count);

            InitializeDataNames(results);

            var itemIndex = this.Units.IndexOf(units);
            bool BaseIs1024 = kilo == "1024" ? true : false;
            bool IsBit = units.IndexOf("bit") >= 0 ? true : false;
            double quantity = Convert.ToDouble(amount);
            double tempQuantity = quantity;

            results[itemIndex].Size = quantity;


            for (int i = itemIndex; ;)
            {
                i -= 2;

                if (i < 0)
                {
                    break;
                }

                if (BaseIs1024)
                {
                    tempQuantity *= 1024;
                }
                else
                {
                    tempQuantity *= 1000;
                }
                results[i].Size = tempQuantity;

                if (IsBit)
                {
                    results[i + 1].Size = results[i].Size / 8;
                }
                else
                {
                    results[i + 1].Size = results[i + 2].Size * 8;
                }
            }

            if (results[0].Size == 0)
            {
                results[0].Size = results[1].Size * 8;
            }

            tempQuantity = quantity;
            for (int i = itemIndex; ;)
            {
                i += 2;

                if (i >= results.Count)
                {
                    break;
                }

                if (BaseIs1024)
                {
                    tempQuantity /= 1024;
                }
                else
                {
                    tempQuantity /= 1000;
                }
                results[i].Size = tempQuantity;

                if (IsBit)
                {
                    results[i - 1].Size = results[i - 2].Size / 8;
                }
                else
                {
                    results[i - 1].Size = results[i].Size * 8;
                }
            }

            if (results[results.Count - 1].Size == 0)
            {
                results[results.Count - 1].Size = results[results.Count - 2].Size / 8;
            }

            this.ViewBag.Results = results;


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}