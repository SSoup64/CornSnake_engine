using System;
using CornSnake;

namespace Program {
public class ObjPlayer : CornSnake.Object {
		double walk_speed = 1.5;

		double hspd = 0, vspd = 0;
		double hspd_frac = 0, vspd_frac = 0;
		
		public new void onCreate(ref Game game) {
			this.sprite = game.spriteGet("spr_test");
		}

		public new void onUpdate(ref Game game) {
			// Input
			bool right	= game.input.keyboardIsHeld(Keyboard.RIGHT);
			bool left	= game.input.keyboardIsHeld(Keyboard.LEFT);
			bool up		= game.input.keyboardIsHeld(Keyboard.UP);
			bool down	= game.input.keyboardIsHeld(Keyboard.DOWN);
			
			bool space	= game.input.keyboardIsPressed(Keyboard.SPACE);
			
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

			this.depth = -this.y;
			// Console.WriteLine(game.instanceExists(test));
			
			x_scale = (float) Math.Sin((float) game.getCurFrame() * Math.PI/180);
			x_scale *= 2;
		}

		public new void onRender(ref Game game) {
			game.renderSetColor(120, 120, 120);
			game.renderDrawRect(0, 0, 100, 100);
			this.renderDrawSelf(ref game);
		}
	}
}


