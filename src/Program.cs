using System;
using CornSnake;

namespace Program {
	class Program {
		static void Main(string[] args) {
			// Create game object and initialize it.
			CornSnake.Game game = new Game();
			game.init();

			game.newObject<CornSnake.Object>(0, 0);

			game.run();

			CornSnake.Sprite spr = new CornSnake.Sprite(game, "./spr_test/");
		}
	}
}
