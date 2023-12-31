using System;
using CornSnake;

namespace Program {
	class ObjTest : CornSnake.Object {
		public override void onCreate(ref Game game) {
			this.sprite = game.spriteGet("spr_test2");
		}

		public override void onUpdate(ref Game game) {
			this.depth = -this.y;
			
			if (game.inputMouseIsPressed(Mouse.LEFT))
				Console.WriteLine("Left was pressed");
			
			if (game.inputMouseIsReleased(Mouse.LEFT))
				Console.WriteLine("Left was released");

			if (game.inputMouseIsHeld(Mouse.RIGHT))
				Console.WriteLine("Right is held");
		}

		public override void onRender(ref Game game) {
			game.renderSetColor(255, 255, 255);
			game.renderDrawRect(x, y, x + 32, y + 32);

			game.renderSetColor(0, 0, 0);
			game.renderDrawRect(x, y, x + 32, y + 32, true);

			renderDrawSelf(ref game);
		}
	}
}
