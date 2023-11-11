using System;
using CornSnake;

namespace Program
{
	public class ObjTest : CornSnake.Object
	{
		public override void onCreate(ref Game game)
		{
			sprite = game.spriteGet("spr_test");
		}
	}
}



