using CornSnake;
using System;

namespace Program
{
	public class ObjTest : CornSnake.Object
	{
		public override void onRender(ref Game game)
		{
			game.renderSetColor(255, 255, 255);
			game.renderDrawRect(0, 24, 100, 200);

			game.renderSetColor(255, 0, 0);
			game.renderDrawCircle(35, 90, 20);

			game.renderSetColor(0, 255, 0);
			game.renderDrawLine(100, 24, 0, 200);
			game.renderDrawLine(0, 24, 100, 200, 2.5);

			game.renderSetColor(0, 0, 255);
			game.renderDrawLine(0, 24, 100, 200);
		}
	}
}
