namespace Mediator;

public interface IMediator
{
    void NotifyRunwayLanding(Runway runway, Aircraft aircraft);
    void NotifyRunwayTakeOff(Runway runway, Aircraft aircraft);
    Runway GetAvailableRunway();
}
