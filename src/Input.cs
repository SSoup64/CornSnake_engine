using System.Runtime.InteropServices;
using System;
using SDL2;

namespace CornSnake {
	public class Input {
		private int keyboard_array_size;
		private IntPtr keyboard_array_org;

		private byte[] keyboard_array;
		private byte[] keyboard_array_delta;

		public void update() {
			// Make the original array
			keyboard_array_org = SDL.SDL_GetKeyboardState(out keyboard_array_size);
			
			// Set keyboard_array_delta
			keyboard_array_delta = keyboard_array;

			// Convert it to the byte array
			keyboard_array = new byte[keyboard_array_size];
			Marshal.Copy(keyboard_array_org, keyboard_array, 0, keyboard_array_size);
		}

#region Keyboard
		public bool keyboardIsHeld(Keyboard key) {
			byte scancode = (byte) SDL.SDL_GetScancodeFromKey((SDL.SDL_Keycode) key);
			return (keyboard_array[scancode] == 1);
		}

		public bool keyboardIsPressed(Keyboard key) {
			byte scancode = (byte) SDL.SDL_GetScancodeFromKey((SDL.SDL_Keycode) key);
			return (keyboard_array[scancode] == 1 && keyboard_array_delta[scancode] == 0);
		}
#endregion
	}
}
