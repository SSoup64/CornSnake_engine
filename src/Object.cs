namespace CornSnake {
	public class Object {
		// Attributes
		public double x, y;

		// Events
		public void onCreate(ref Game game) {}
		public void onUpdate(ref Game game) {}
		public void onDestroy(ref Game game) {}

		// Constructor and destructor
		public Object(ref Game game) {
			onCreate(ref game);
		}

		~Object() {

		}
	}
}
