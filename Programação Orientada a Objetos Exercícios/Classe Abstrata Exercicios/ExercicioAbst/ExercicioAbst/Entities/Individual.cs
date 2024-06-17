namespace ExercicioAbst.Entities
{
    internal class Individual:TaxPayer
    {
        public double HelthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double helthExpenditures):base(name, anualIncome)
        {
            HelthExpenditures = helthExpenditures;
        }

        public override double Tax()
        {
           return (AnualIncome*0.25) - (HelthExpenditures * 0.5);
        }
    }
}
