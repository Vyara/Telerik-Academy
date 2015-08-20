//Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.

namespace VersionAttibute
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]

    class Version : Attribute
    {

        //properties
        public string VersionAtribute { get; set; }

        public Type Component { get; set; }

        public string Name { get; set; }

        //constructor
        public Version(Type component, string name, string version)
        {
            this.Component = component;
            this.Name = name;
            this.VersionAtribute = version;
        }

        //methods
        public override string ToString()
        {
            return this.VersionAtribute;
        }
    }
}
