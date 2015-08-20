//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).


using System;
using System.Text;



class Call
{
    //fields
    private DateTime dateTime;
    private string phoneNumber;
    private ulong duration;

    //constructor
    public Call(string phoneNumber, ulong duration)
    {
        this.PhoneNumber = phoneNumber;
        this.Duration = duration;
        this.DateTime = DateTime.Now;
    }

    //properties
    public DateTime DateTime
    {
        get
        {
            if (this.dateTime.Equals(null))
            {
                throw new NullReferenceException("Date and time of call should not be empty");
            }

            return this.dateTime;
        }

        private set
        {
            this.dateTime = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return this.phoneNumber;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Number must not be null or empty.");
            }

            this.phoneNumber = value;
        }
    }

    public ulong Duration
    {
        get
        {
            return this.duration;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Call duration must be >= 0.");
            }

            this.duration = value;
        }
    }

    //methods
    public override string ToString()
    {
        var callInfo = new StringBuilder();
        callInfo.AppendFormat("Number: {0}", this.PhoneNumber);
        callInfo.AppendLine();
        callInfo.AppendFormat("Made on: {0} at {1}", this.DateTime.ToShortDateString(), this.DateTime.ToShortTimeString());
        callInfo.AppendLine();
        callInfo.AppendFormat("Duration: {0:F2} seconds", this.Duration);

        return callInfo.ToString();
    }
}

