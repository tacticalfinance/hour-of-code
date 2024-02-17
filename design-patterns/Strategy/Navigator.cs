namespace design_patterns.Strategy;

public class Navigator : INavigator
{
    public IRoute Navigate(NavigationType navigationType, ICoordinate pointA, ICoordinate pointB)
    {
        var divider = 1;
        switch (navigationType)
        {
            case NavigationType.Flying:
                divider = 1;
                break;
            case NavigationType.Driving:
                divider = 2;
                break;
            case NavigationType.Cycling:
                divider = 4;
                break;
        }

        IRoute route = new Route(navigationType);
        double longitudeStep = (pointB.Longitude - pointA.Longitude) / divider;
        double latitudeStep = (pointB.Latitude - pointA.Latitude) / divider;
        Enumerable.Range(0, divider + 1)
            .Select(i =>
                new Coordinate(pointA.Latitude + i * latitudeStep, pointA.Longitude + i * longitudeStep))
            .ToList().ForEach(c => route.AddCoordinate(c));
        return route;
    }
}