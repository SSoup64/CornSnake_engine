using System;
using CornSnake;

namespace Program {
	public class ObjTest : CornSnake.Object {
		public int foo;

		public void onCreate(ref Game game) {
			Console.WriteLine("This is working");

			this.sprite = new Sprite(ref game, "./spr_test/");
		}
	}

	class Program {
		static void Main(string[] args) {
			// Create game object and initialize it.
			CornSnake.Game game = new CornSnake.Game(60);

			game.init(1024, 768);
			game.cameraResize(256, 192);
			
			// Create objects
			game.newObject<ObjTest>(32, 16);
			
			// Run the game
			game.run();
		}
	}
}
