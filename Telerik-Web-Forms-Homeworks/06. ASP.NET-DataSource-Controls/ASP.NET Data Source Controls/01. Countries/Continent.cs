//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Continents
{
    using System;
    using System.Collections.Generic;
    
    public partial class Continent
    {
        public Continent()
        {
            this.Countries = new HashSet<Country>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Country> Countries { get; set; }
    }
}
