namespace Mediator
{
    using System;
    
    public class Program
    {
        static void Main(string[] args)
        {
            Runway[] runways = { new Runway(), new Runway() };
    
            Aircraft[] aircrafts = { new Aircraft("Plane1"), new Aircraft("Plane2") };
            var commandCentre = new CommandCentre(runways, aircrafts);

            foreach (var aircraft in aircrafts)
            {
                aircraft.SetMediator(commandCentre);
            }

            aircrafts[0].Land();
            aircrafts[1].Land();

            aircrafts[0].TakeOff();
            aircrafts[1].TakeOff();
        }

    }
}