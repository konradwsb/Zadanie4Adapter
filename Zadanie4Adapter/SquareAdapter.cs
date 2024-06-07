public class SquareAdapter : IShape
{
    private Square square;

    public SquareAdapter(Square square)
    {
        this.square = square;
    }

    public double GetArea()
    {
        double side = square.GetSide();
        return side * side;
    }
}