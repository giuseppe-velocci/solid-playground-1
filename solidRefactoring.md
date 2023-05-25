:::mermaid
%%{init: {'theme':'dark', 'flowchart':{'curve':'linear'}}}%%

classDiagram
 direction LR


class IPathValidator{
    <<interface>> 
    +ValidatePathCoordinates(Coordinate start, Coordinate target)
}
class IMapValueValidator{
    <<interface>> 
    +IsMapValueValid(Coordinate point)
}
class IWithMapIPathValidator["IWithMap[IPathValidator]"]{
    <<interface>> 
    +WithMap(IEnumerable[int[]] map)
}
class IWithMapIMapValueValidator["IWithMap[IMapValueValidator]"]{
    <<interface>> 
    +WithMap(IEnumerable[int[]] map)
}

class IPathFinderFactory{
    <<interface>> 
    +Create(Vehicles vehicle, IEnumerable[int[]] map)
}
class IPathFinder{
    <<interface>> 
    +Find(Coordinate start, Coordinate target)
}

class PathValidator{
    -IEnumerable[int[]] Map
    -ValidatePathCoordinates(Coordinate start, Coordinate target)
    +WithMap(IEnumerable[int[]] map)
}

class PlaneMapValidator{
    -IEnumerable[int[]] Map
    -IPathValidator PathValidator
    +IsMapValueValid(Coordinate point)
    +WithMap(IEnumerable[int[]] map)
}
class VesselMapValidator{
    -IEnumerable[int[]] Map
    -IPathValidator PathValidator
    +IsMapValueValid(Coordinate point)
    +WithMap(IEnumerable[int[]] map)
}

class PathFinder{
    -IEnumerable[int[]] Map
    -IMapValueValidator Validator
    +Find(Coordinate start, Coordinate target)
    -GetAvailableSteps(Coordinate point)
}
class PathFinderFactory{
    "-IDictionary[Vehicles, IWithMap[IMapValueValidator]] Constructors"
    +Create(Vehicles vehicle, IEnumerable[int[] ] map)
}

class Vehicles{
    <<enumerable>> 
    Plane
    Vessel
}

%%working init
PathFinderFactory ..|> IPathFinderFactory

IPathFinder ..|> PathFinder

PathValidator ..|> IPathValidator 

PlaneMapValidator ..|> IMapValueValidator
VesselMapValidator  ..|> IMapValueValidator
%%working end

%%not bad
PathValidator --> PlaneMapValidator
PathValidator --> VesselMapValidator

IPathValidator ..|> IMapValueValidator
IMapValueValidator --> PathFinder

PathFinderFactory --> PathFinder : pathfinder 1
%%end not bad

PathValidator ..|> IWithMapIPathValidator
PlaneMapValidator ..|> IWithMapIMapValueValidator 
VesselMapValidator ..|> IWithMapIMapValueValidator 

:::