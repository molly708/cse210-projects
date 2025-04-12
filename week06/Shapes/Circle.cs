using System;

namespace Shapes
{
  public class Circle : Shape
  {
    private float _radius;

    public Circle(string color, float radius) : base(color)
    {
      _radius = radius;
    }

    public override double GetArea()
    {
      return Math.PI * _radius * _radius;
    }
  }
}