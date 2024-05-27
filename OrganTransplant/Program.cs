namespace OrganTransplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oppretter objekter for Bernt (pasienten) og Kåre (donoren)
            Person bernt = new Person("Bernt");
            Person kåre = new Person("Kåre");

            Organ nyre = new Organ("Nyre");

            // Starter transplantasjonsprosessen
            Console.WriteLine($"En akutt ulykke har skjedd, og {bernt.Name} trenger en ny {nyre.Type}!");

            Console.WriteLine($"{kåre.Name} frivillig melder seg som donor for å redde {bernt.Name}.");

            Console.WriteLine("Gjennomfører nyretransplantasjon...");
            Transplant(bernt, kåre, nyre);

            Console.WriteLine($"Nyretransplantasjonen er gjennomført vellykket! {bernt.Name} har nå en ny {nyre.Type} og er i bedring.");
        }

        static void Transplant(Person recipient, Person donor, Organ organ)
        {
            Console.WriteLine($"{donor.Name} gir villig bort en {organ.Type} til {recipient.Name}.");
        }
    }
}
