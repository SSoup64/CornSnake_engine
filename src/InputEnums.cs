using Raylib_cs;

namespace CornSnake
{
	// This enum is literally just the Raylib keycode enum without the KEY_ prefix.
	// May god forgive me
	public enum Mouse
	{
		LEFT = 0,
		RIGHT = 1,
		MIDDLE = 2,
		SIDE = 3,
		EXTRA = 4,
		FOWARD = 5,
		BACK = 6,
	}

	public enum Keyboard
	{
		NULL = 0,

		// Alphanumeric keys
		APOSTROPHE = 39,
		COMMA = 44,
		MINUS = 45,
		PERIOD = 46,
		SLASH = 47,
		ZERO = 48,
		ONE = 49,
		TWO = 50,
		THREE = 51,
		FOUR = 52,
		FIVE = 53,
		SIX = 54,
		SEVEN = 55,
		EIGHT = 56,
		NINE = 57,
		SEMICOLON = 59,
		EQUAL = 61,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,

		// Function keys
		SPACE = 32,
		ESCAPE = 256,
		ENTER = 257,
		TAB = 258,
		BACKSPACE = 259,
		INSERT = 260,
		DELETE = 261,
		RIGHT = 262,
		LEFT = 263,
		DOWN = 264,
		UP = 265,
		PAGE_UP = 266,
		PAGE_DOWN = 267,
		HOME = 268,
		END = 269,
		CAPS_LOCK = 280,
		SCROLL_LOCK = 281,
		NUM_LOCK = 282,
		PRINT_SCREEN = 283,
		PAUSE = 284,
		F1 = 290,
		F2 = 291,
		F3 = 292,
		F4 = 293,
		F5 = 294,
		F6 = 295,
		F7 = 296,
		F8 = 297,
		F9 = 298,
		F10 = 299,
		F11 = 300,
		F12 = 301,
		LEFT_SHIFT = 340,
		LEFT_CONTROL = 341,
		LEFT_ALT = 342,
		LEFT_SUPER = 343,
		RIGHT_SHIFT = 344,
		RIGHT_CONTROL = 345,
		RIGHT_ALT = 346,
		RIGHT_SUPER = 347,
		KB_MENU = 348,
		LEFT_BRACKET = 91,
		BACKSLASH = 92,
		RIGHT_BRACKET = 93,
		GRAVE = 96,

		// Keypad keys
		KP_0 = 320,
		KP_1 = 321,
		KP_2 = 322,
		KP_3 = 323,
		KP_4 = 324,
		KP_5 = 325,
		KP_6 = 326,
		KP_7 = 327,
		KP_8 = 328,
		KP_9 = 329,
		KP_DECIMAL = 330,
		KP_DIVIDE = 331,
		KP_MULTIPLY = 332,
		KP_SUBTRACT = 333,
		KP_ADD = 334,
		KP_ENTER = 335,
		KP_EQUAL = 336,
	};

	public enum GamepadButton
	{
		UNKNOWN = 0,

		LEFT_FACE_UP,
		LEFT_FACE_RIGHT,
		LEFT_FACE_DOWN,
		LEFT_FACE_LEFT,

		RIGHT_FACE_UP,
		RIGHT_FACE_RIGHT,
		RIGHT_FACE_DOWN,
		RIGHT_FACE_LEFT,

		LEFT_TRIGGER_1,
		LEFT_TRIGGER_2,

		RIGHT_TRIGGER_1,
		RIGHT_TRIGGER_2,
		
		MIDDLE_LEFT,
		MIDDLE,
		MIDDLE_RIGHT,

		LEFT_THUMB,
		RIGHT_THUMB
	};

	public enum GamepadAxis
	{
		GAMEPAD_AXIS_LEFT_X = 0,
		GAMEPAD_AXIS_LEFT_Y = 1,

		GAMEPAD_AXIS_RIGHT_X = 2,
		GAMEPAD_AXIS_RIGHT_Y = 3,

		GAMEPAD_AXIS_LEFT_TRIGGER = 4,

		GAMEPAD_AXIS_RIGHT_TRIGGER = 5
	};
}
