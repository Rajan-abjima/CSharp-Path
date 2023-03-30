using FluentAssertions;
using System;
using Xunit;
using TimeinTests;

namespace TimeinTests.Tests.Unit;

public class GreeterServiceTest
{
    [Fact]
    void GenerateGreetText_ShouldReturnGoodMorning_whenItsMorning()
    {
        //Arrange
        var sut = new GreeterService();
        //Act
        var message = sut.GenerateGreetText();
        //Assert
        message.Should().Be("Good Morning");
    }

    [Fact]
    void GenerateGreetText_ShouldReturnGoodAfternoon_whenItsAfternoon()
    {
        //Arrange
        var sut = new GreeterService();
        //Act
        var message = sut.GenerateGreetText();
        //Assert
        message.Should().Be("Good Afternoon");
    }
}