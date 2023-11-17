using System;
using CS = CornSnake;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			CS.Game game = new CS.Game();

			game.init(1024, 768, "Gamepad testing", 60);

			game.run();
		}
	}
}


