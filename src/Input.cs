using System.Runtime.InteropServices;
using System;
using Raylib_cs;

namespace CornSnake {
	public class Input {
#region Keyboard
		public bool keyboardIsHeld(Keyboard key) {
			return Raylib.IsKeyDown((Raylib_cs.KeyboardKey) key);
		}

		public bool keyboardIsPressed(Keyboard key) {
			return Raylib.IsKeyPressed((Raylib_cs.KeyboardKey) key);
		}
#endregion
	}
}
