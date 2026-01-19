using System.ComponentModel.DataAnnotations;

namespace Student.Data.Attributes;

public class NotFutureDateAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value == null)
            return true; // Let Required attribute handle null checks
        
        if (value is DateTime date)
        {
            return date <= DateTime.Today;
        }
        
        return false;
    }
    
    public override string FormatErrorMessage(string name)
    {
        return $"{name} must not be in the future.";
    }
}

