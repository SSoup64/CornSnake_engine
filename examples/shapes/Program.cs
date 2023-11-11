using CornSnake;
using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create game
			CornSnake.Game game = new CornSnake.Game();
			
			// Init game
			game.init(1024, 768, "Shapes thing", 60);

			// Create objects
			game.instanceCreate<ObjTest>(0, 0);

			// Resize camera
			game.cameraResize(3);

			// Run game
			game.run();
		}
	}
}


