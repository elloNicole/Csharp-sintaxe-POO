namespace ExercicioInterrup.Entities.Exeptions
{
    internal class DomainException : Exception
    {
        public DomainException (string message) : base (message) { }
    }
}
