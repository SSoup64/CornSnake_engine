using System;
using CornSnake;

namespace Program {
	class ObjTest : CornSnake.Object {
		public new void onCreate(ref Game game) {
			this.sprite = game.spriteGet("spr_test2");
		}

		public new void onUpdate(ref Game game) {
			this.depth = -this.y;
		}
	}
}
