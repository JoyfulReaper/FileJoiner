using FileJoinerLibrary;
using Xunit;

namespace FileJoinerLibrary.Tests;

public sealed class FileJoinerTests : IDisposable
{
    private readonly string testDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

    public FileJoinerTests()
    {
        Directory.CreateDirectory(testDirectory);
    }

    [Fact]
    public void JoinFiles_AppendsBinaryFilesInOrder()
    {
        FileInfo first = WriteBytes("first.bin", 0x01, 0x02);
        FileInfo second = WriteBytes("second.bin", 0x03, 0x04, 0x05);
        string outputFile = Path.Combine(testDirectory, "output.bin");

        FileJoiner.JoinFiles(new List<FileInfo> { first, second }, outputFile);

        Assert.Equal(new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 }, File.ReadAllBytes(outputFile));
    }

    [Fact]
    public void JoinTextFiles_InsertsConfiguredNewLinesBetweenFiles()
    {
        FileInfo first = WriteText("first.txt", "alpha");
        FileInfo second = WriteText("second.txt", "beta");
        string outputFile = Path.Combine(testDirectory, "output.txt");

        FileJoiner.JoinTextFiles(new List<FileInfo> { first, second }, 2, outputFile);

        Assert.Equal($"alpha{Environment.NewLine}{Environment.NewLine}beta", File.ReadAllText(outputFile));
    }

    [Fact]
    public void JoinTextFiles_DoesNotAddTrailingNewLines()
    {
        FileInfo input = WriteText("single.txt", "alpha");
        string outputFile = Path.Combine(testDirectory, "output.txt");

        FileJoiner.JoinTextFiles(new List<FileInfo> { input }, 3, outputFile);

        Assert.Equal("alpha", File.ReadAllText(outputFile));
    }

    [Fact]
    public void JoinFiles_OverwritesExistingOutputFile()
    {
        FileInfo input = WriteBytes("input.bin", 0xAA);
        string outputFile = Path.Combine(testDirectory, "output.bin");
        File.WriteAllBytes(outputFile, new byte[] { 0x01, 0x02, 0x03 });

        FileJoiner.JoinFiles(new List<FileInfo> { input }, outputFile);

        Assert.Equal(new byte[] { 0xAA }, File.ReadAllBytes(outputFile));
    }

    [Fact]
    public void JoinFiles_WithNoInputFilesCreatesEmptyOutputFile()
    {
        string outputFile = Path.Combine(testDirectory, "output.bin");

        FileJoiner.JoinFiles(new List<FileInfo>(), outputFile);

        Assert.True(File.Exists(outputFile));
        Assert.Empty(File.ReadAllBytes(outputFile));
    }

    public void Dispose()
    {
        if (Directory.Exists(testDirectory))
        {
            Directory.Delete(testDirectory, recursive: true);
        }
    }

    private FileInfo WriteBytes(string fileName, params byte[] bytes)
    {
        string filePath = Path.Combine(testDirectory, fileName);
        File.WriteAllBytes(filePath, bytes);
        return new FileInfo(filePath);
    }

    private FileInfo WriteText(string fileName, string contents)
    {
        string filePath = Path.Combine(testDirectory, fileName);
        File.WriteAllText(filePath, contents);
        return new FileInfo(filePath);
    }
}
