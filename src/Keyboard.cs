using SDL2;

namespace CornSnake {
	public enum Keyboard {
		KEY_UNKNOWN = SDL.SDL_Keycode.SDLK_UNKNOWN,
		KEY_RETURN = SDL.SDL_Keycode.SDLK_RETURN,
		KEY_ESCAPE = SDL.SDL_Keycode.SDLK_ESCAPE,
		KEY_BACKSPACE = SDL.SDL_Keycode.SDLK_BACKSPACE,
		KEY_TAB = SDL.SDL_Keycode.SDLK_TAB,
		KEY_SPACE = SDL.SDL_Keycode.SDLK_SPACE,
		KEY_EXCLAIM = SDL.SDL_Keycode.SDLK_EXCLAIM,
		KEY_QUOTEDBL = SDL.SDL_Keycode.SDLK_QUOTEDBL,
		KEY_HASH = SDL.SDL_Keycode.SDLK_HASH,
		KEY_PERCENT = SDL.SDL_Keycode.SDLK_PERCENT,
		KEY_DOLLAR = SDL.SDL_Keycode.SDLK_DOLLAR,
		KEY_AMPERSAND = SDL.SDL_Keycode.SDLK_AMPERSAND,
		KEY_QUOTE = SDL.SDL_Keycode.SDLK_QUOTE,
		KEY_LEFTPAREN = SDL.SDL_Keycode.SDLK_LEFTPAREN,
		KEY_RIGHTPAREN = SDL.SDL_Keycode.SDLK_RIGHTPAREN,
		KEY_ASTERISK = SDL.SDL_Keycode.SDLK_ASTERISK,
		KEY_PLUS = SDL.SDL_Keycode.SDLK_PLUS,
		KEY_COMMA = SDL.SDL_Keycode.SDLK_COMMA,
		KEY_MINUS = SDL.SDL_Keycode.SDLK_MINUS,
		KEY_PERIOD = SDL.SDL_Keycode.SDLK_PERIOD,
		KEY_SLASH = SDL.SDL_Keycode.SDLK_SLASH,
		KEY_0 = SDL.SDL_Keycode.SDLK_0,
		KEY_1 = SDL.SDL_Keycode.SDLK_1,
		KEY_2 = SDL.SDL_Keycode.SDLK_2,
		KEY_3 = SDL.SDL_Keycode.SDLK_3,
		KEY_4 = SDL.SDL_Keycode.SDLK_4,
		KEY_5 = SDL.SDL_Keycode.SDLK_5,
		KEY_6 = SDL.SDL_Keycode.SDLK_6,
		KEY_7 = SDL.SDL_Keycode.SDLK_7,
		KEY_8 = SDL.SDL_Keycode.SDLK_8,
		KEY_9 = SDL.SDL_Keycode.SDLK_9,
		KEY_COLON = SDL.SDL_Keycode.SDLK_COLON,
		KEY_SEMICOLON = SDL.SDL_Keycode.SDLK_SEMICOLON,
		KEY_LESS = SDL.SDL_Keycode.SDLK_LESS,
		KEY_EQUALS = SDL.SDL_Keycode.SDLK_EQUALS,
		KEY_GREATER = SDL.SDL_Keycode.SDLK_GREATER,
		KEY_QUESTION = SDL.SDL_Keycode.SDLK_QUESTION,
		KEY_AT = SDL.SDL_Keycode.SDLK_AT,
		KEY_LEFTBRACKET = SDL.SDL_Keycode.SDLK_LEFTBRACKET,
		KEY_BACKSLASH = SDL.SDL_Keycode.SDLK_BACKSLASH,
		KEY_RIGHTBRACKET = SDL.SDL_Keycode.SDLK_RIGHTBRACKET,
		KEY_CARET = SDL.SDL_Keycode.SDLK_CARET,
		KEY_UNDERSCORE = SDL.SDL_Keycode.SDLK_UNDERSCORE,
		KEY_BACKQUOTE = SDL.SDL_Keycode.SDLK_BACKQUOTE,
		KEY_a = SDL.SDL_Keycode.SDLK_a,
		KEY_b = SDL.SDL_Keycode.SDLK_b,
		KEY_c = SDL.SDL_Keycode.SDLK_c,
		KEY_d = SDL.SDL_Keycode.SDLK_d,
		KEY_e = SDL.SDL_Keycode.SDLK_e,
		KEY_f = SDL.SDL_Keycode.SDLK_f,
		KEY_g = SDL.SDL_Keycode.SDLK_g,
		KEY_h = SDL.SDL_Keycode.SDLK_h,
		KEY_i = SDL.SDL_Keycode.SDLK_i,
		KEY_j = SDL.SDL_Keycode.SDLK_j,
		KEY_k = SDL.SDL_Keycode.SDLK_k,
		KEY_l = SDL.SDL_Keycode.SDLK_l,
		KEY_m = SDL.SDL_Keycode.SDLK_m,
		KEY_n = SDL.SDL_Keycode.SDLK_n,
		KEY_o = SDL.SDL_Keycode.SDLK_o,
		KEY_p = SDL.SDL_Keycode.SDLK_p,
		KEY_q = SDL.SDL_Keycode.SDLK_q,
		KEY_r = SDL.SDL_Keycode.SDLK_r,
		KEY_s = SDL.SDL_Keycode.SDLK_s,
		KEY_t = SDL.SDL_Keycode.SDLK_t,
		KEY_u = SDL.SDL_Keycode.SDLK_u,
		KEY_v = SDL.SDL_Keycode.SDLK_v,
		KEY_w = SDL.SDL_Keycode.SDLK_w,
		KEY_x = SDL.SDL_Keycode.SDLK_x,
		KEY_y = SDL.SDL_Keycode.SDLK_y,
		KEY_z = SDL.SDL_Keycode.SDLK_z,
		KEY_CAPSLOCK = SDL.SDL_Keycode.SDLK_CAPSLOCK,
		KEY_F1 = SDL.SDL_Keycode.SDLK_F1,
		KEY_F2 = SDL.SDL_Keycode.SDLK_F2,
		KEY_F3 = SDL.SDL_Keycode.SDLK_F3,
		KEY_F4 = SDL.SDL_Keycode.SDLK_F4,
		KEY_F5 = SDL.SDL_Keycode.SDLK_F5,
		KEY_F6 = SDL.SDL_Keycode.SDLK_F6,
		KEY_F7 = SDL.SDL_Keycode.SDLK_F7,
		KEY_F8 = SDL.SDL_Keycode.SDLK_F8,
		KEY_F9 = SDL.SDL_Keycode.SDLK_F9,
		KEY_F10 = SDL.SDL_Keycode.SDLK_F10,
		KEY_F11 = SDL.SDL_Keycode.SDLK_F11,
		KEY_F12 = SDL.SDL_Keycode.SDLK_F12,
		KEY_PRINTSCREEN = SDL.SDL_Keycode.SDLK_PRINTSCREEN,
		KEY_SCROLLLOCK = SDL.SDL_Keycode.SDLK_SCROLLLOCK,
		KEY_PAUSE = SDL.SDL_Keycode.SDLK_PAUSE,
		KEY_INSERT = SDL.SDL_Keycode.SDLK_INSERT,
		KEY_HOME = SDL.SDL_Keycode.SDLK_HOME,
		KEY_PAGEUP = SDL.SDL_Keycode.SDLK_PAGEUP,
		KEY_DELETE = SDL.SDL_Keycode.SDLK_DELETE,
		KEY_END = SDL.SDL_Keycode.SDLK_END,
		KEY_PAGEDOWN = SDL.SDL_Keycode.SDLK_PAGEDOWN,
		KEY_RIGHT = SDL.SDL_Keycode.SDLK_RIGHT,
		KEY_LEFT = SDL.SDL_Keycode.SDLK_LEFT,
		KEY_DOWN = SDL.SDL_Keycode.SDLK_DOWN,
		KEY_UP = SDL.SDL_Keycode.SDLK_UP,
		KEY_NUMLOCKCLEAR = SDL.SDL_Keycode.SDLK_NUMLOCKCLEAR,
		KEY_KP_DIVIDE = SDL.SDL_Keycode.SDLK_KP_DIVIDE,
		KEY_KP_MULTIPLY = SDL.SDL_Keycode.SDLK_KP_MULTIPLY,
		KEY_KP_MINUS = SDL.SDL_Keycode.SDLK_KP_MINUS,
		KEY_KP_PLUS = SDL.SDL_Keycode.SDLK_KP_PLUS,
		KEY_KP_ENTER = SDL.SDL_Keycode.SDLK_KP_ENTER,
		KEY_KP_1 = SDL.SDL_Keycode.SDLK_KP_1,
		KEY_KP_2 = SDL.SDL_Keycode.SDLK_KP_2,
		KEY_KP_3 = SDL.SDL_Keycode.SDLK_KP_3,
		KEY_KP_4 = SDL.SDL_Keycode.SDLK_KP_4,
		KEY_KP_5 = SDL.SDL_Keycode.SDLK_KP_5,
		KEY_KP_6 = SDL.SDL_Keycode.SDLK_KP_6,
		KEY_KP_7 = SDL.SDL_Keycode.SDLK_KP_7,
		KEY_KP_8 = SDL.SDL_Keycode.SDLK_KP_8,
		KEY_KP_9 = SDL.SDL_Keycode.SDLK_KP_9,
		KEY_KP_0 = SDL.SDL_Keycode.SDLK_KP_0,
		KEY_KP_PERIOD = SDL.SDL_Keycode.SDLK_KP_PERIOD,
		KEY_APPLICATION = SDL.SDL_Keycode.SDLK_APPLICATION,
		KEY_POWER = SDL.SDL_Keycode.SDLK_POWER,
		KEY_KP_EQUALS = SDL.SDL_Keycode.SDLK_KP_EQUALS,
		KEY_F13 = SDL.SDL_Keycode.SDLK_F13,
		KEY_F14 = SDL.SDL_Keycode.SDLK_F14,
		KEY_F15 = SDL.SDL_Keycode.SDLK_F15,
		KEY_F16 = SDL.SDL_Keycode.SDLK_F16,
		KEY_F17 = SDL.SDL_Keycode.SDLK_F17,
		KEY_F18 = SDL.SDL_Keycode.SDLK_F18,
		KEY_F19 = SDL.SDL_Keycode.SDLK_F19,
		KEY_F20 = SDL.SDL_Keycode.SDLK_F20,
		KEY_F21 = SDL.SDL_Keycode.SDLK_F21,
		KEY_F22 = SDL.SDL_Keycode.SDLK_F22,
		KEY_F23 = SDL.SDL_Keycode.SDLK_F23,
		KEY_F24 = SDL.SDL_Keycode.SDLK_F24,
		KEY_EXECUTE = SDL.SDL_Keycode.SDLK_EXECUTE,
		KEY_HELP = SDL.SDL_Keycode.SDLK_HELP,
		KEY_MENU = SDL.SDL_Keycode.SDLK_MENU,
		KEY_SELECT = SDL.SDL_Keycode.SDLK_SELECT,
		KEY_STOP = SDL.SDL_Keycode.SDLK_STOP,
		KEY_AGAIN = SDL.SDL_Keycode.SDLK_AGAIN,
		KEY_UNDO = SDL.SDL_Keycode.SDLK_UNDO,
		KEY_CUT = SDL.SDL_Keycode.SDLK_CUT,
		KEY_COPY = SDL.SDL_Keycode.SDLK_COPY,
		KEY_PASTE = SDL.SDL_Keycode.SDLK_PASTE,
		KEY_FIND = SDL.SDL_Keycode.SDLK_FIND,
		KEY_MUTE = SDL.SDL_Keycode.SDLK_MUTE,
		KEY_VOLUMEUP = SDL.SDL_Keycode.SDLK_VOLUMEUP,
		KEY_VOLUMEDOWN = SDL.SDL_Keycode.SDLK_VOLUMEDOWN,
		KEY_KP_COMMA = SDL.SDL_Keycode.SDLK_KP_COMMA,
		KEY_KP_EQUALSAS400  = SDL.SDL_Keycode.SDLK_KP_EQUALSAS400 ,
		KEY_ALTERASE = SDL.SDL_Keycode.SDLK_ALTERASE,
		KEY_SYSREQ = SDL.SDL_Keycode.SDLK_SYSREQ,
		KEY_CANCEL = SDL.SDL_Keycode.SDLK_CANCEL,
		KEY_CLEAR = SDL.SDL_Keycode.SDLK_CLEAR,
		KEY_PRIOR = SDL.SDL_Keycode.SDLK_PRIOR,
		KEY_RETURN2 = SDL.SDL_Keycode.SDLK_RETURN2,
		KEY_SEPARATOR = SDL.SDL_Keycode.SDLK_SEPARATOR,
		KEY_OUT = SDL.SDL_Keycode.SDLK_OUT,
		KEY_OPER = SDL.SDL_Keycode.SDLK_OPER,
		KEY_CLEARAGAIN = SDL.SDL_Keycode.SDLK_CLEARAGAIN,
		KEY_CRSEL = SDL.SDL_Keycode.SDLK_CRSEL,
		KEY_EXSEL = SDL.SDL_Keycode.SDLK_EXSEL,
		KEY_KP_00 = SDL.SDL_Keycode.SDLK_KP_00,
		KEY_KP_000 = SDL.SDL_Keycode.SDLK_KP_000,
		KEY_THOUSANDSSEPARATOR  = SDL.SDL_Keycode.SDLK_THOUSANDSSEPARATOR ,
		KEY_DECIMALSEPARATOR  = SDL.SDL_Keycode.SDLK_DECIMALSEPARATOR ,
		KEY_CURRENCYUNIT = SDL.SDL_Keycode.SDLK_CURRENCYUNIT,
		KEY_CURRENCYSUBUNIT  = SDL.SDL_Keycode.SDLK_CURRENCYSUBUNIT ,
		KEY_KP_LEFTPAREN = SDL.SDL_Keycode.SDLK_KP_LEFTPAREN,
		KEY_KP_RIGHTPAREN = SDL.SDL_Keycode.SDLK_KP_RIGHTPAREN,
		KEY_KP_LEFTBRACE = SDL.SDL_Keycode.SDLK_KP_LEFTBRACE,
		KEY_KP_RIGHTBRACE = SDL.SDL_Keycode.SDLK_KP_RIGHTBRACE,
		KEY_KP_TAB = SDL.SDL_Keycode.SDLK_KP_TAB,
		KEY_KP_BACKSPACE = SDL.SDL_Keycode.SDLK_KP_BACKSPACE,
		KEY_KP_A = SDL.SDL_Keycode.SDLK_KP_A,
		KEY_KP_B = SDL.SDL_Keycode.SDLK_KP_B,
		KEY_KP_C = SDL.SDL_Keycode.SDLK_KP_C,
		KEY_KP_D = SDL.SDL_Keycode.SDLK_KP_D,
		KEY_KP_E = SDL.SDL_Keycode.SDLK_KP_E,
		KEY_KP_F = SDL.SDL_Keycode.SDLK_KP_F,
		KEY_KP_XOR = SDL.SDL_Keycode.SDLK_KP_XOR,
		KEY_KP_POWER = SDL.SDL_Keycode.SDLK_KP_POWER,
		KEY_KP_PERCENT = SDL.SDL_Keycode.SDLK_KP_PERCENT,
		KEY_KP_LESS = SDL.SDL_Keycode.SDLK_KP_LESS,
		KEY_KP_GREATER = SDL.SDL_Keycode.SDLK_KP_GREATER,
		KEY_KP_AMPERSAND = SDL.SDL_Keycode.SDLK_KP_AMPERSAND,
		KEY_KP_DBLAMPERSAND  = SDL.SDL_Keycode.SDLK_KP_DBLAMPERSAND ,
		KEY_KP_VERTICALBAR  = SDL.SDL_Keycode.SDLK_KP_VERTICALBAR ,
		KEY_KP_DBLVERTICALBAR  = SDL.SDL_Keycode.SDLK_KP_DBLVERTICALBAR ,
		KEY_KP_COLON = SDL.SDL_Keycode.SDLK_KP_COLON,
		KEY_KP_HASH = SDL.SDL_Keycode.SDLK_KP_HASH,
		KEY_KP_SPACE = SDL.SDL_Keycode.SDLK_KP_SPACE,
		KEY_KP_AT = SDL.SDL_Keycode.SDLK_KP_AT,
		KEY_KP_EXCLAM = SDL.SDL_Keycode.SDLK_KP_EXCLAM,
		KEY_KP_MEMSTORE = SDL.SDL_Keycode.SDLK_KP_MEMSTORE,
		KEY_KP_MEMRECALL = SDL.SDL_Keycode.SDLK_KP_MEMRECALL,
		KEY_KP_MEMCLEAR = SDL.SDL_Keycode.SDLK_KP_MEMCLEAR,
		KEY_KP_MEMADD = SDL.SDL_Keycode.SDLK_KP_MEMADD,
		KEY_KP_MEMSUBTRACT  = SDL.SDL_Keycode.SDLK_KP_MEMSUBTRACT ,
		KEY_KP_MEMMULTIPLY  = SDL.SDL_Keycode.SDLK_KP_MEMMULTIPLY ,
		KEY_KP_MEMDIVIDE = SDL.SDL_Keycode.SDLK_KP_MEMDIVIDE,
		KEY_KP_PLUSMINUS = SDL.SDL_Keycode.SDLK_KP_PLUSMINUS,
		KEY_KP_CLEAR = SDL.SDL_Keycode.SDLK_KP_CLEAR,
		KEY_KP_CLEARENTRY = SDL.SDL_Keycode.SDLK_KP_CLEARENTRY,
		KEY_KP_BINARY = SDL.SDL_Keycode.SDLK_KP_BINARY,
		KEY_KP_OCTAL = SDL.SDL_Keycode.SDLK_KP_OCTAL,
		KEY_KP_DECIMAL = SDL.SDL_Keycode.SDLK_KP_DECIMAL,
		KEY_KP_HEXADECIMAL  = SDL.SDL_Keycode.SDLK_KP_HEXADECIMAL ,
		KEY_LCTRL = SDL.SDL_Keycode.SDLK_LCTRL,
		KEY_LSHIFT = SDL.SDL_Keycode.SDLK_LSHIFT,
		KEY_LALT = SDL.SDL_Keycode.SDLK_LALT,
		KEY_LGUI = SDL.SDL_Keycode.SDLK_LGUI,
		KEY_RCTRL = SDL.SDL_Keycode.SDLK_RCTRL,
		KEY_RSHIFT = SDL.SDL_Keycode.SDLK_RSHIFT,
		KEY_RALT = SDL.SDL_Keycode.SDLK_RALT,
		KEY_RGUI = SDL.SDL_Keycode.SDLK_RGUI,
		KEY_MODE = SDL.SDL_Keycode.SDLK_MODE,
		KEY_AUDIONEXT = SDL.SDL_Keycode.SDLK_AUDIONEXT,
		KEY_AUDIOPREV = SDL.SDL_Keycode.SDLK_AUDIOPREV,
		KEY_AUDIOSTOP = SDL.SDL_Keycode.SDLK_AUDIOSTOP,
		KEY_AUDIOPLAY = SDL.SDL_Keycode.SDLK_AUDIOPLAY,
		KEY_AUDIOMUTE = SDL.SDL_Keycode.SDLK_AUDIOMUTE,
		KEY_MEDIASELECT = SDL.SDL_Keycode.SDLK_MEDIASELECT,
		KEY_WWW = SDL.SDL_Keycode.SDLK_WWW,
		KEY_MAIL = SDL.SDL_Keycode.SDLK_MAIL,
		KEY_CALCULATOR = SDL.SDL_Keycode.SDLK_CALCULATOR,
		KEY_COMPUTER = SDL.SDL_Keycode.SDLK_COMPUTER,
		KEY_AC_SEARCH = SDL.SDL_Keycode.SDLK_AC_SEARCH,
		KEY_AC_HOME = SDL.SDL_Keycode.SDLK_AC_HOME,
		KEY_AC_BACK = SDL.SDL_Keycode.SDLK_AC_BACK,
		KEY_AC_FORWARD = SDL.SDL_Keycode.SDLK_AC_FORWARD,
		KEY_AC_STOP = SDL.SDL_Keycode.SDLK_AC_STOP,
		KEY_AC_REFRESH = SDL.SDL_Keycode.SDLK_AC_REFRESH,
		KEY_AC_BOOKMARKS = SDL.SDL_Keycode.SDLK_AC_BOOKMARKS,
		KEY_BRIGHTNESSDOWN  = SDL.SDL_Keycode.SDLK_BRIGHTNESSDOWN ,
		KEY_BRIGHTNESSUP = SDL.SDL_Keycode.SDLK_BRIGHTNESSUP,
		KEY_DISPLAYSWITCH = SDL.SDL_Keycode.SDLK_DISPLAYSWITCH,
		KEY_KBDILLUMTOGGLE  = SDL.SDL_Keycode.SDLK_KBDILLUMTOGGLE ,
		KEY_KBDILLUMDOWN = SDL.SDL_Keycode.SDLK_KBDILLUMDOWN,
		KEY_KBDILLUMUP = SDL.SDL_Keycode.SDLK_KBDILLUMUP,
		KEY_EJECT = SDL.SDL_Keycode.SDLK_EJECT,
		KEY_SLEEP = SDL.SDL_Keycode.SDLK_SLEEP,
		KEY_APP1 = SDL.SDL_Keycode.SDLK_APP1,
		KEY_APP2 = SDL.SDL_Keycode.SDLK_APP2,
		KEY_AUDIOREWIND = SDL.SDL_Keycode.SDLK_AUDIOREWIND,
		KEY_AUDIOFASTFORWARD  = SDL.SDL_Keycode.SDLK_AUDIOFASTFORWARD ,
	}
}