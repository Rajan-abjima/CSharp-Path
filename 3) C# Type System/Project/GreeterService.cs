namespace TimeinTests;

public class GreeterService
{   public string GenerateGreetText()
    {
        var dateTimeNow = DateTimeOffset.Now;
        return dateTimeNow.Hour switch
        {
            >= 5 and < 12 => "Good morning",
            >= 12 and < 18 => "Good afternoon",
            _ => "Good evening "
        };
    }
}