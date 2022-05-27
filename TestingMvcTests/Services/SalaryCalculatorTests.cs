using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestningMvc.Services;

namespace TestingMvcTests.Services;

[TestClass]
public class SalaryCalculatorTests
{
    private SalaryCalculator sut; // SYSTEM UNDER TEST
    public SalaryCalculatorTests()
    {
        sut = new SalaryCalculator();
    }

    [TestMethod]
    public void Under30_should_get_100_kr_per_hour()
    {
        // ARRANGE
        var age = 17;
        var hours = 10;
        var expected = 1000;

        //ACT
        var result = sut.Calculate("", age, hours);

        //ASSERT
        Assert.AreEqual(expected,result);
    }

    [TestMethod]
    public void Between30And50_should_get_120_kr_per_hour()
    {
        // ARRANGE
        var age = 35;
        var hours = 10;
        var expected = 1200;

        //ACT
        var result = sut.Calculate("", age, hours);

        //ASSERT
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    public void Over50_should_get_130_kr_per_hour()
    {
        // ARRANGE
        var age = 55;
        var hours = 10;
        var expected = 1300;

        //ACT
        var result = sut.Calculate("", age, hours);

        //ASSERT
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    public void Over50AndStefan_should_get_143_kr_per_hour()
    {
        // ARRANGE
        var age = 55;
        var hours = 10;
        var expected = 1430;

        //ACT
        var result = sut.Calculate("Stefan", age, hours);

        //ASSERT
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    public void Between30And50AndStefan_should_get_132_kr_per_hour()
    {
        // ARRANGE
        var age = 35;
        var hours = 10;
        var expected = 1320;

        //ACT
        var result = sut.Calculate("Stefan", age, hours);

        //ASSERT
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Under30AndStefan_should_get_110_kr_per_hour()
    {
        // ARRANGE
        var age = 17;
        var hours = 10;
        var expected = 1100;

        //ACT
        var result = sut.Calculate("Stefan", age, hours);

        //ASSERT
        Assert.AreEqual(expected, result);
    }






}