namespace DI
{
    public class PeakItService : IPeakItService
    {
        private string connectionString;
        
        public PeakItService(string connString)
        {
            this.connectionString = connString;
        }

        public string GetConstructorParameter()
        {
            return connectionString;
        }
    }
}
