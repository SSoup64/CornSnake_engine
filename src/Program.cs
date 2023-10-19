using System;
using CornSnake;

namespace Program {
	class Program {
		static void Main(string[] args) {
			// Create game object and initialize it.
			CornSnake.Game game = new Game(60);
			game.init();
			
			// Create sprites
			CornSnake.Sprite spr = new CornSnake.Sprite(game, "./spr_test/");
			
			// Create objects
			game.newObject<CornSnake.Object>(0, 0);
			
			// Run the game
			game.run();
		}
	}
}
