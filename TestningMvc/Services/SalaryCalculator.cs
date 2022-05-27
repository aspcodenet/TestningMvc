namespace TestningMvc.Services;

public class SalaryCalculator : ISalaryCalculator
{
    //public int Calculate(string namn, int age, int antalTimmar)
    //{
    //    int salaryPerHour = 100;
    //    if (age >= 30 && age <= 50) salaryPerHour = 120;
    //    else if (age > 50) salaryPerHour = 130;

    //    if (namn == "Stefan")
    //        salaryPerHour = Convert.ToInt32(Convert.ToDecimal(salaryPerHour) * 1.1m);

    //    return salaryPerHour * antalTimmar;
    //}


    public int Calculate(string namn, int age, int antalTimmar)
    {
        int salaryPerHour = 0;
        if (age < 30)
            salaryPerHour = 100;
        else if (age <= 50) 
            salaryPerHour = 120;
        else 
            salaryPerHour = 130;

        if (namn == "Stefan")
            salaryPerHour = Convert.ToInt32(Convert.ToDecimal(salaryPerHour) * 1.1m);

        return salaryPerHour * antalTimmar;
    }

}