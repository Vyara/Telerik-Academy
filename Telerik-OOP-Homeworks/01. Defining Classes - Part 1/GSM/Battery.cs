//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

using System;


class Battery
{
    //fields
    private string model;
    private ulong? hoursIdle;
    private ulong? hoursTalk;
    private Type batteryType;

    //enumeration for the battery type
    public enum Type
    {
        LiIon,
        NiMH,
        NiCd,
        NA //not available            
    }

    //constructors
    public Battery(string model)
    {
        this.Model = model;
        this.HoursIdle = null;
        this.HoursTalk = null;

    }

    //inherits from first constructor
    public Battery(string model, ulong hoursIdle)
        : this(model)
    {
        this.HoursIdle = hoursIdle;
        this.HoursTalk = null;
    }


    //inherits from second constructor
    public Battery(string model, ulong hoursIdle, ulong hoursTalk)
        : this(model, hoursIdle)
    {
        this.HoursTalk = hoursTalk;
    }

    //TODO: add a batteryType constructor if needed
    public Battery(string model, ulong hoursIdle, ulong hoursTalk, Type batteryType)
        : this(model, hoursIdle, hoursTalk)
    {
        this.batteryType = batteryType;
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

    public ulong? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("\"Hours idle\" value needs to be >= 0.");
            }

            this.hoursIdle = value;
        }
    }

    public ulong? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("\"Hours talk\" value needs to be >= 0.");
            }

            this.hoursTalk = value;
        }
    }

    public Type BatteryType
    {
        get
        {
            return this.batteryType;
        }
    }


}
