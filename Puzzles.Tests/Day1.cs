using aspire_aoc.Puzzles.Day1;
using FluentAssertions;

namespace Puzzles.Tests;

public class Day1Tests
{
    private readonly Day1 _puzzle;

    public Day1Tests()
    {
        _puzzle = new Day1();
    }
    
    [Theory]
    [InlineData(true, 24000)]
    [InlineData(false, 69177)]
    public async Task Part1(bool solveSample, int answer)
    {
        // Act
        var solution = await _puzzle.SolvePart1(solveSample);
        
        // Assert
        solution.Should().Be(answer);
    }
    
    [Theory]
    [InlineData(true, 45000)]
    [InlineData(false, 207456)]
    public async Task Part2(bool solveSample, int answer)
    {
        // Act
        var solution = await _puzzle.SolvePart2(solveSample);
        
        // Assert
        solution.Should().Be(answer);
    }
}