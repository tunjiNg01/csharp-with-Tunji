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
		virtual public void Write() { Console.WriteLine("Base write method"); }
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

		//public override void DrawLine()
		//{
			//base.DrawLine();
			//Console.WriteLine("Derived is Drawing Line {0}");
		//}
		new public void Write()
		{
			Console.WriteLine("Member for custom graphics");
		}
    }

}

