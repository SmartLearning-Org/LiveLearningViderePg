using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal abstract class Kunde
    {
        public Guid Nummer { get; protected init; }

        public string? Gade { get; set; }

        public string? Postnummer { get; set; }

        public string By
        {
            get
            {
                return PostnummerHelper.GetByFromPostnummer(Postnummer ?? throw new ArgumentException());
            }
        }

        public abstract string GetName();

        public Kunde()
        {
            Nummer = Guid.NewGuid();
        }

        public Kunde(string? gade, string? postnummer) : base()
        {
            Gade = gade;
            Postnummer = postnummer;
        }
    }
    class PrivatKunde : Kunde
    {
        public string? Fornavn { get; set; }
        public string? Efternavn { get; set; }

        public PrivatKunde(string? fornavn, string? efternavn, string? gade, string? postnummer) : base(gade, postnummer)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
        }

        public override string GetName()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }

    class ErhvervKunde : Kunde
    {
        public string? Firmanavn { get; set; }

        public ErhvervKunde(string? firmanavn, string? gade, string? postnummer) : base(gade, postnummer)
        {
            Firmanavn = firmanavn;
        }

        public override string GetName()
        {
            return $"{Firmanavn}";
        }
    }
}


