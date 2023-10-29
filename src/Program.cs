﻿// This file is literally just to test out the features of the engine.

using System;
using CornSnake;

namespace Program {
	public class ObjPlayer : CornSnake.Object {
		double walk_speed = 1.5;

		double hspd = 0, vspd = 0;
		double hspd_frac = 0, vspd_frac = 0;
		
		public new void onCreate(ref Game game) {
			this.sprite = new Sprite(ref game, "./spr_test/");
		}

		public new void onUpdate(ref Game game) {
			// Input
			bool right	= game.input.keyboardIsHeld(Keyboard.KEY_RIGHT);
			bool left	= game.input.keyboardIsHeld(Keyboard.KEY_LEFT);
			bool up		= game.input.keyboardIsHeld(Keyboard.KEY_UP);
			bool down	= game.input.keyboardIsHeld(Keyboard.KEY_DOWN);
			
			bool space	= game.input.keyboardIsPressed(Keyboard.KEY_SPACE);
			
			// Find the direction along the x and y axis
			int dir_x = Convert.ToInt32(right) - Convert.ToInt32(left);
			int dir_y = Convert.ToInt32(down) - Convert.ToInt32(up);
			
			// Calculate hspd
			hspd = walk_speed * dir_x;

			hspd		+= hspd_frac;
			hspd_frac	= hspd - Math.Floor(Math.Abs(hspd)) * Math.Sign(hspd);
			hspd		-= hspd_frac;
			
			// Calculate vspd
			vspd = walk_speed * dir_y;

			vspd		+= vspd_frac;
			vspd_frac	= vspd - Math.Floor(Math.Abs(vspd)) * Math.Sign(vspd);
			vspd		-= vspd_frac;

			// Add hspd to x
			this.x += Convert.ToInt32(hspd);
			this.y += Convert.ToInt32(vspd);


			// Console.WriteLine(game.instanceExists(test));
		}
	}

	class ObjCamera : CornSnake.Object {
		CornSnake.Object follow;
		int smoothness = 4;

		public new void onCreate(ref Game game) {
			follow = (CornSnake.Object) game.instanceFind<ObjPlayer>();

			this.x = game.cameraGetX();
			this.y = game.cameraGetY();
		}

		public new void onUpdate(ref Game game) {
			// Calculate the camera_x_to and camera_y_to variables 
			int camera_x_to = Math.Max(0, follow.x - game.cameraGetWidth()/2);
			int camera_y_to = Math.Max(0, follow.y - game.cameraGetHeight()/2);
			
			// Calculate new X and Y
			this.x += (camera_x_to - game.cameraGetX())/this.smoothness;
			this.y += (camera_y_to - game.cameraGetY())/this.smoothness;
			
			// Set the camera's position
			game.cameraSetPos(this.x, this.y);
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
			game.instanceCreate<ObjPlayer>(16, 16);
			game.instanceCreate<ObjCamera>(0, 0);
			
			// Run the game
			game.run();
		}
	}
}
