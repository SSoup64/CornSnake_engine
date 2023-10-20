// This file is literally just to test out the features of the engine.

using System;
using CornSnake;

namespace Program {
	public class ObjTest : CornSnake.Object {
		public int foo;
		
		public void onCreate(ref Game game) {
			Console.WriteLine("This is working");

			this.sprite = new Sprite(ref game, "./spr_test/");
		}

		public void onUpdate(ref Game game) {
			this.x++;
			
			if (this.x > game.cameraGetWidth())
				this.x = -sprite.getWidth();
		}
	}

	class Program {
		static void Main(string[] args) {
			// Create game object and initialize it.
			CornSnake.Game game = new CornSnake.Game(60);
			
			// Initialize the game and set camera size
			game.init(1024, 768);
			game.cameraResize(256, 192);
			
			// Create objects
			game.newObject<ObjTest>(32, 16);
			
			// Run the game
			game.run();
		}
	}
}
