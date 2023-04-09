
namespace CourseLibrary.API.Helpers;
public static class DateTimeOffsetExtensions
{
    public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
    {
        /*
        This "if" statement checks if the current date is earlier than 
        the date equivalent to the input date with the age in years added.
        If the current date is earlier, it means the person has not yet 
        celebrated their birthday this year, so we need to subtract 1 from
        the age to get the correct age. Therefore, the "age" variable is
        decremented by 1.
        
        
        */
        var currentDate = DateTime.UtcNow;
        int age = currentDate.Year - dateTimeOffset.Year;

        if (currentDate < dateTimeOffset.AddYears(age))
        {
            age--;
        }

        return age;
    }
}

