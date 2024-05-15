namespace Mediator;

public class Runway
{
    public readonly Guid Id = Guid.NewGuid();
    public bool IsBusy { get; private set; }

    public void Occupy()
    {
        this.IsBusy = true;
    }

    public void Vacate()
    {
        this.IsBusy = false;
    }
}
