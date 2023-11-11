using CornSnake;
using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			CornSnake.Game game = new CornSnake.Game();
			
			// Initialize the game
			game.init(1024, 768, "My Game", 60);
			
			// Load sprites
			game.spriteLoad("spr_test");
			
			// Resize the camera
			game.cameraResize(4);
			
			// Create objects
			game.instanceCreate<ObjTest>(0, 0);
			
			// Run the game
			game.run();
		}
	}
}
