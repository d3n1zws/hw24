namespace ConsoleApp24.records;

public class CustomerRecord
{
    static int id = 0;
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
}

// (Immutability xassəsi test edilməlidir).