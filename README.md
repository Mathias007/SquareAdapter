`SquareAdapter.cs` pseudocode:
```
interface ITarget:
    method GetRequest() -> string

class Square:
    field side: float

    constructor Square(sideLength: float):
        this.side = sideLength

    method GetArea() -> float:
        return side * side

class SquareAdapter implements ITarget:
    field square: Square

    constructor SquareAdapter(square: Square):
        this.square = square

    method GetRequest() -> string:
        area = square.GetArea()
        return "Area of the square is " + area

function Main():
    square = Square(5)
    target = SquareAdapter(square)
    print("Adapting Square class to ITarget interface:")
    print(target.GetRequest())
```
