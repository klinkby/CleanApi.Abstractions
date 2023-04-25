namespace Klinkby.CleanApi;

/// <summary>
/// Define an executable command
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Execute the command asynchronously
    /// </summary>
    /// <param name="cancellation">Token for cancelling the execution before completion</param>
    /// <returns>A <see cref="ValueTask"/></returns>
    ValueTask ExecuteAsync(CancellationToken cancellation);
}
