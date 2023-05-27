:::mermaid

classDiagram
direction LR

class PathFinder{
    -IEnumerable[int[]] Map
    +Find(Coordinate start, Coordinate target)
    -ValidateInputCoordinates(Coordinate start, Coordinate target, string vehicle)
    -GetAvailableSteps(Coordinate point)
}

PathFinder
:::