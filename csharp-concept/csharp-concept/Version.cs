using System;
namespace csharp_concept
{
	public class Graphics
	{
		public Graphics()
		{
		}
		public virtual void DrawLine() { Console.WriteLine("Base is drwaing line"); }
		public virtual void DrawSquare() { Console.WriteLine("Base is drwaing square"); }
	}

	public class CustomGraphics: Graphics
	{
		public CustomGraphics()
		{

		}
        
        public new void DrawSquare()
        {
            base.DrawSquare();
        }

		public override void DrawLine()
		{
			Console.WriteLine("Derived is Drawing Line {0}");
		}
    }

}

