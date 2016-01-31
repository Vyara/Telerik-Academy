namespace Cars.Utils
{
    using System.Collections.Generic;
    using Models;

    public class Initializer
    {
        public static IList<Producer> Producers { get; set; }

        public static IList<Extra> Extras { get; set; }

        public static IList<string> EngineTypes { get; set; }
    }
}