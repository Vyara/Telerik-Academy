using System;


class Display
{
    //fields
    private ulong height;
    private ulong width;
    private ulong? numberOfColors;

    //constructors
    public Display(ulong height, ulong width)
    {
        this.Height = height;
        this.Width = width;
        this.NumberOfColors = null;
    }

    public Display(ulong height, ulong width, ulong numberOfColors)
        : this(height, width)
    {
        this.NumberOfColors = numberOfColors;
    }

    //properties
    public ulong Height
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Display height needs to be > 0.");
            }

            this.height = value;
        }
    }

    public ulong Width
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Display width needs to be > 0.");
            }

            this.width = value;
        }
    }

    public ulong? NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Display number of colors needs to be > 0.");
            }

            this.numberOfColors = value;
        }
    }

}
