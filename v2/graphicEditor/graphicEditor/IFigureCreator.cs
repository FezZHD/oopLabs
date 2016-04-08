namespace graphicEditor
{
    public interface IFigureCreator
    {
        Shape GetShape();
    }

    class CreateLine:IFigureCreator
    {
        public Shape GetShape()
        {
            return new Line(2);
        }
    }


    class CreateTriangle : IFigureCreator
    {
        public Shape GetShape()
        {
            return new Triangle(3);
        }
    }


    class CreateRectangle : IFigureCreator
    {
        public Shape GetShape()
        {
            return new MyRectanlge(4);
        }
    }


    class CreateCircle : IFigureCreator
    {
        public Shape GetShape()
        {
            return new MyCircle(2);
        }
    }

    class CreateEllipse : IFigureCreator
    {
        public Shape GetShape()
        {
            return new MyEllipse(2);
        }
    }

    class CreatePentagon : IFigureCreator
    {
        public Shape GetShape()
        {
            return new Pentagon(5);
        }
    }
    
}
