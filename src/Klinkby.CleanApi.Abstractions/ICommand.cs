namespace Clean;

/// <summary>
/// Define an executable command
/// </summary>
public interface ICommand
{
    ValueTask ExecuteAsync(CancellationToken cancellation);
}
