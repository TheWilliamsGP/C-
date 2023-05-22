using POE;
namespace calorieTest;

public class CaloriesTest1
{
    private Recipe _calorieCalculator { get; set; } = null!;
    [SetUp]
    public void Setup()
    {
        _calorieCalculator = new Recipe();
    }

    [Test]
    public void calorieCalculator_Test()
    {

        //assign
        var totalCalories = 0;

        //act
        var calorie = _calorieCalculator.

        //assert
        Assert.Pass();
    }
}
