using Xunit;


public class UnitTest1
{
    [Fact]
    public void LessThen50Test()
    {
        Assert.Equal(4, CatFoodStore.Price(2));
        Assert.NotEqual(5, CatFoodStore.Price(2));

    }

    [Fact]
    public void MoreThen50Test()
    {
        Assert.Equal(116.25, CatFoodStore.Price(75));
        Assert.NotEqual(150, CatFoodStore.Price(75));
    }

    [Fact]
    public void MoreThen100Test()
    {
        Assert.Equal(150, CatFoodStore.Price(100));
        Assert.Equal(151.5, CatFoodStore.Price(101));
        Assert.NotEqual(155, CatFoodStore.Price(101));
    }
}