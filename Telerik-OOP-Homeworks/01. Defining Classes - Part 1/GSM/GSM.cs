//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
//battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
//Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
//Add a method in the GSM class for displaying all information about it.
//Try to override ToString().
//Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
//Add a property CallHistory in the GSM class to hold a list of the performed calls.
//Try to use the system class List<Call>.
//Add methods in the GSM class for adding and deleting calls from the calls history.
//Add a method to clear the call history.
//Add a method that calculates the total price of the calls in the call history.
//Assume the price per minute is fixed and is provided as a parameter.

using System;
using System.Collections.Generic;
using System.Text;



class GSM
{
    //fields

    //iPhone 4S field
    private static readonly GSM iPone4S = new GSM("iPone4S", "Apple", 240, new Battery("1432 mAh", 200, 8, Battery.Type.LiIon), new Display(960, 640, 16000000));

    //call history field
    private readonly List<Call> callHistory = new List<Call>();

    private string model;
    private string manufacturer;
    private decimal? price;
    private string owner;


    //constructors
    public GSM(string model, string manufacturer)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = null;
        this.Owner = null;
    }

    //inherits from fist constructor
    public GSM(string model, string manufacturer, decimal price)
        : this(model, manufacturer)
    {
        this.Price = price;
        this.Owner = null;
    }

    //inherits from second constructor
    public GSM(string model, string manufacturer, decimal price, string owner)
        : this(model, manufacturer, price)
    {
        this.Owner = owner;
    }

    //with battery specs
    public GSM(string model, string manufacturer, Battery battery)
        : this(model, manufacturer)
    {
        this.Battery = battery;
    }

    //with display specs
    public GSM(string model, string manufacturer, Display display)
        : this(model, manufacturer)
    {
        this.Display = display;
    }

    //full specs without owner
    public GSM(string model, string manufacturer, decimal price, Battery battery, Display display)
        : this(model, manufacturer, price)
    {
        this.Battery = battery;
        this.Display = display;
        this.Owner = null;
    }

    //full specs 
    public GSM(string model, string manufacturer, decimal price, Battery battery, Display display, string owner)
        : this(model, manufacturer, price, battery, display)
    {
        this.Owner = owner;
    }

    //properties
    public string Model
    {
        get
        {
            return this.model;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("\"Model\" filed cannot be null or empty.");
            }

            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("\"Manufacturer\" filed cannot be null or empty.");
            }

            this.manufacturer = value;
        }
    }

    public decimal? Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price needs to be >= 0.");
            }
            this.price = value;
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }

        set
        {
            if (value == String.Empty)
            {
                throw new ArgumentException("\"Owner\" filed cannot be empty.");
            }
            this.owner = value;
        }
    }

    //properties for getting battery and display information
    public Battery Battery { get; set; }

    public Display Display { get; set; }

    //iPhone4S static property
    public static GSM IPhone4S
    {
        get
        {
            return iPone4S;
        }
    }

    //property to hold call history
    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }

    }


    //methods

    //adding a call
    public void AddACall(Call call)
    {
        this.CallHistory.Add(call);
    }

    //deleting a call
    public void DeleteACall(Call call)
    {
        this.CallHistory.Remove(call);
    }

    //clearing the call history
    public void ClearCallHistory()
    {
        this.CallHistory.Clear();
    }

    //calculating total call price
    public decimal CallPrice(decimal pricePerMinute)
    {
        decimal totalDuration = 0;

        foreach (var call in this.CallHistory)
        {
            totalDuration += call.Duration;
        }

        var totalPrice = pricePerMinute * (totalDuration / 60.0M);

        return totalPrice;
    }


    //overriding To.String for displaying all information about the GSM
    public override string ToString()
    {
        var specs = new StringBuilder();
        specs.AppendLine("Specifications");
        specs.AppendLine(new string('-', 30));
        specs.AppendFormat("Model: {0}", this.Model);
        specs.AppendLine();
        specs.AppendFormat("Manifacturer: {0}", this.Manufacturer);
        specs.AppendLine();
        if (this.Price != null)
        {
            specs.AppendFormat("Price: {0}", this.Price);
            specs.AppendLine();
        }

        if (this.Owner != null)
        {
            specs.AppendFormat("Owner: {0}", this.Owner);
            specs.AppendLine();
        }

        if (this.Battery != null)
        {
            specs.AppendLine("Battery:");
            specs.AppendFormat("  Model: {0}", this.Battery.Model);
            specs.AppendLine();
            specs.AppendFormat("  Type: {0}", this.Battery.BatteryType);
            specs.AppendLine();

            if (this.Battery.HoursIdle != null)
            {
                specs.AppendFormat("  Hours Idle: {0}", this.Battery.HoursIdle);
                specs.AppendLine();
            }

            if (this.Battery.HoursTalk != null)
            {
                specs.AppendFormat("  Hours Talk: {0}", this.Battery.HoursTalk);
                specs.AppendLine();
            }

        }

        if (this.Display != null)
        {
            specs.AppendLine("Display:");
            specs.AppendFormat("  Size: {0} x {1}", this.Display.Height, this.Display.Width);
            specs.AppendLine();

            if (this.Display.NumberOfColors != null)
            {
                specs.AppendFormat("  Colors: {0}", this.Display.NumberOfColors);
            }
        }

        specs.AppendLine();

        return specs.ToString();
    }
}

