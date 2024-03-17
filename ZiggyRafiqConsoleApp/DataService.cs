namespace ZiggyRafiqConsoleApp
{
    public class DataService
    {
        private readonly IDataSource _dataSource;

        public DataService(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public string ProcessData()
        {
            return _dataSource.GetData().ToUpper();
        }
    }

}
