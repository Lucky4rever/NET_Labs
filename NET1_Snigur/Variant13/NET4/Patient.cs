﻿namespace DOTNET.Variant13.NET4
{
    class Patient
    {
        public string Name;

        public Patient(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
