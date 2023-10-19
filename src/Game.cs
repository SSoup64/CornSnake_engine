using System;

namespace CornSnake {
	public class Game {
		// Attributes
		private List<Object> objects;
		
		// Constructor
		public Game() {
			objects = new List<Object>();
		}
		
		// Other functions
		void newObject<T>(double x, double y) {
			var me = this;

			Object base_obj = new Object(ref me);

			base_obj.x = x;
			base_obj.y = y;

			// T obj = (T) (Convert.ChangeType(base_obj, typeof(T)));

			objects.Add((Object) (Convert.ChangeType(base_obj, typeof(T))));
		}
	}
}

