using LabCicdApi8;

namespace LabCicdApi8.Tests;

public class WeatherForecastTests
{
    [Fact]
    public void WeatherForecast_TemperatureF_DeveCalcularParaZeroGraus()
    {
        // Arrange
        var forecast = new WeatherForecast(DateOnly.FromDateTime(DateTime.Now), 0, "Freezing");

        // Act
        var tempF = forecast.TemperatureF;

        // Assert
        Assert.Equal(99, tempF);
    }

    [Fact]
    public void WeatherForecast_TemperatureF_DeveCalcularParaCemGraus()
    {
        // Arrange
        var forecast = new WeatherForecast(DateOnly.FromDateTime(DateTime.Now), 100, "Hot");

        // Act
        var tempF = forecast.TemperatureF;

        // Assert
        Assert.Equal(211, tempF);
    }
}