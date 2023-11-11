using System;
using Raylib_cs;

namespace CornSnake
{
	public enum HitboxType
	{
		rectangle,
	}

	public class Hitbox
	{
		HitboxType type;
		int x, y, height, width;
		
		public Hitbox(HitboxType type, int x, int y, int height, int width)
		{
			this.type	= type;
			this.x		= x;
			this.y		= y;
			this.width	= width;
			this.height	= height;
		}
	}
}

