// This file is literally just to test out the features of the engine.

using System;
using CornSnake;

// TEMPORARY
using SDL2;

namespace Program {
	public class ObjTest : CornSnake.Object {
		int walk_speed = 2;
		int hspd = 0, vspd = 0;
		
		public void onCreate(ref Game game) {
			Console.WriteLine("This is working");

			this.sprite = new Sprite(ref game, "./spr_test/");
		}

		public void onUpdate(ref Game game) {
			// Input
			bool right	= game.input.keyboardIsHeld(CornSnake.Keyboard.KEY_RIGHT);
			bool left	= game.input.keyboardIsHeld(CornSnake.Keyboard.KEY_LEFT);
			
			// Find the direction along the x axis
			int dir_x = Convert.ToInt32(right) - Convert.ToInt32(left);
			
			// Find hspd
			hspd = walk_speed * dir_x;

			// Add hspd to x
			this.x += hspd;
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
