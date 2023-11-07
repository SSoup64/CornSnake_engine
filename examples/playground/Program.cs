using System;
using CornSnake;

namespace Program {
	class Program {
		static void Main(string[] args) {
			// Create game object and initialize it.
			CornSnake.Game game = new CornSnake.Game();
			
			// Initialize the game and set camera size
			game.init(1024, 768, "Game", 60);

			// Load sprites
			game.spriteLoad("spr_test");
			game.spriteLoad("spr_test2");
			
			// Create objects
			game.instanceCreate<ObjTest>(64, 32);
			game.instanceCreate<ObjPlayer>(16, 16);
			game.instanceCreate<ObjCamera>(0, 0);
			
			game.cameraResize(4);

			// Run the game
			game.run();
		}
	}
}
