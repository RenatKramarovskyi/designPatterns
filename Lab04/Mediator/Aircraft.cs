using Mediator;

public class Aircraft
{
    private IMediator _mediator;
    public string Name;
    public Runway CurrentRunway { get; set; }

    public Aircraft(string name)
    {
        this.Name = name;
    }

    public void SetMediator(IMediator mediator)
    {
        this._mediator = mediator;
    }

    public void Land()
    {
        var runway = _mediator.GetAvailableRunway();
        if (runway != null)
        {
            Console.WriteLine(new string('=', 30));
            _mediator.NotifyRunwayLanding(runway, this);
            this.CurrentRunway = runway;
            Console.WriteLine(new string('=', 30));

        }
    }

    public void TakeOff()
    {
        if (this.CurrentRunway != null)
        {
            Console.WriteLine(new string('=', 30));
            _mediator.NotifyRunwayTakeOff(this.CurrentRunway, this);
            this.CurrentRunway = null;
            Console.WriteLine(new string('=', 30));
        }
        else
        {
            Console.WriteLine($"Aircraft {this.Name} cannot take off without a runway.");
        }
    }
}