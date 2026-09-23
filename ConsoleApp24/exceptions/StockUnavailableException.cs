namespace ConsoleApp24.exceptions;

public class StockUnavailableException: Exception
{
    public StockUnavailableException(string Message): base(Message)
    {
        
    }
}
