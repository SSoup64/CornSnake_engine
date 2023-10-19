using System;
using SDL2;

namespace CornSnake {
	class Program {
		static void Main(string[] args) {
			Game game = new Game();
			game.newObject<Object>(0, 0);

			game.run();
		}
	}
}
