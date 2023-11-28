using aspire_aoc.Puzzles.Day2;
using FluentAssertions;

namespace Puzzles.Tests;

public class Day2Tests
{
    private readonly Day2 _puzzle;

    public Day2Tests()
    {
        _puzzle = new Day2();
    }
    
    [Theory]
    [InlineData(true, 15)]
    [InlineData(false, 11666)]
    public async Task Part1(bool solveSample, int answer)
    {
        // Act
        var solution = await _puzzle.SolvePart1(solveSample);
        
        // Assert
        solution.Should().Be(answer);
    }
    
    [Theory]
    [InlineData(true, 12)]
    [InlineData(false, 12767)]
    public async Task Part2(bool solveSample, int answer)
    {
        // Act
        var solution = await _puzzle.SolvePart2(solveSample);
        
        // Assert
        solution.Should().Be(answer);
    }
}