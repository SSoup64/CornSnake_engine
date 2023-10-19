using System;
using SDL2;

namespace CornSnake {
	public class Game {
		// Attributes
		private List<Object> objects;
		
		// Constructor
		public Game() {
			objects = new List<Object>();
		}
		
		// Run function
		public void run() {
			SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

			var window = SDL.SDL_CreateWindow("Title", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, 1024, 768, 0);
			bool end = false;
		
			SDL.SDL_Event ev;

			while (!end) {
				while (SDL.SDL_PollEvent(out ev) != 0) {
					switch (ev.type) {
						case SDL.SDL_EventType.SDL_QUIT:
							end = true;
							break;
					}
				}
			}

			SDL.SDL_DestroyWindow(window);

			SDL.SDL_Quit();
		}

		// Other functions
		public void newObject<T>(double x, double y) {
			var me = this;

			Object base_obj = new Object(ref me);

			base_obj.x = x;
			base_obj.y = y;

			// T obj = (T) (Convert.ChangeType(base_obj, typeof(T)));

			objects.Add((Object) (Convert.ChangeType(base_obj, typeof(T))));
		}
	}
}

