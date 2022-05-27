namespace TestningMvc.Services;

public interface ISalaryCalculator
{
    int Calculate(string namn, int age, int antalTimmar);
}