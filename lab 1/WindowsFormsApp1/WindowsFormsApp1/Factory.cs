using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ITruckerFactory
    {
        ITruck CreateTruck();
        IDriver CreateDriver();
    }
    public class FordTruckerFactory : ITruckerFactory
    {
        public ITruck CreateTruck()
        {
            return new FordTruck();
        }

        public IDriver CreateDriver()
        {
            return new FordDriver();
        }
    }

    public class ChevyTruckerFactory : ITruckerFactory
    {
        public ITruck CreateTruck()
        {
            return new ChevyTruck();
        }

        public IDriver CreateDriver()
        {
            return new ChevyDriver();
        }
    }

    public class VolvoTruckerFactory : ITruckerFactory
    {
        public ITruck CreateTruck()
        {
            return new VolvoTruck();
        }

        public IDriver CreateDriver()
        {
            return new VolvoDriver();
        }
    }
    public interface ITruck
    {
        string GetBrand();
    }

    public interface IDriver
    {
        string GetCompanyName();
    }

    public class FordTruck : ITruck
    {
        public string GetBrand()
        {
            return "Ford";
        }
    }

    public class ChevyTruck : ITruck
    {
        public string GetBrand()
        {
            return "Chevy";
        }
    }

    public class VolvoTruck : ITruck
    {
        public string GetBrand()
        {
            return "Volvo";
        }
    }

    public class FordDriver : IDriver
    {
        public string GetCompanyName()
        {
            return "Ford Trucking Inc.";
        }
    }

    public class ChevyDriver : IDriver
    {
        public string GetCompanyName()
        {
            return "Chevy Trucking Inc.";
        }
    }

    public class VolvoDriver : IDriver
    {
        public string GetCompanyName()
        {
            return "Volvo Trucking Inc.";
        }
    }
}
