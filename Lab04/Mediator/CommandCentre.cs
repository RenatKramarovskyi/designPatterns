namespace Mediator;

class CommandCentre : IMediator
{
    private List<Runway> _runways = new List<Runway>();
    private List<Aircraft> _aircrafts = new List<Aircraft>();

    public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
    {
        this._runways.AddRange(runways);
        this._aircrafts.AddRange(aircrafts);
    }

    public Runway GetAvailableRunway()
    {
        return _runways.FirstOrDefault(r => !r.IsBusy);
    }

    public void NotifyRunwayLanding(Runway runway, Aircraft aircraft)
    {
        if (!runway.IsBusy)
        {
            runway.Occupy();
            aircraft.CurrentRunway = runway;
            Console.WriteLine($"Aircraft {aircraft.Name} is landing...");
            Console.WriteLine($"Aircraft {aircraft.Name} is landing....");
            Console.WriteLine($"Aircraft {aircraft.Name} has landed!");
        }
        else
        {
            Console.WriteLine($"Could not land, the runway {runway.Id} is busy.");
        }
    }

    public void NotifyRunwayTakeOff(Runway runway, Aircraft aircraft)
    {
        runway.Vacate();
        aircraft.CurrentRunway = null;
        Console.WriteLine($"Aircraft {aircraft.Name} is taking off...");
        Console.WriteLine($"Aircraft {aircraft.Name} is taking off....");
        Console.WriteLine($"Aircraft {aircraft.Name} has taken off !");
    }
}
