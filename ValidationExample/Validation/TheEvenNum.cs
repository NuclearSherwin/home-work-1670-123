using System.ComponentModel.DataAnnotations;

public class TheEven : ValidationAttribute
{
    public TheEven() => ErrorMessage = "{0} must be the even number";

    public override bool IsValid(object value)
    {
        if (value == null) return false;

        int i = int.Parse(value.ToString());

        return i % 2 == 0;
    }
}