// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.LuaStateInterop.LuaBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
  public class LuaBase
  {
    protected const int LUA_TNONE = -1;
    protected const int LUA_TNIL = 0;
    protected const int LUA_TBOOLEAN = 1;
    protected const int LUA_TLIGHTUSERDATA = 2;
    protected const int LUA_TNUMBER = 3;
    protected const int LUA_TSTRING = 4;
    protected const int LUA_TTABLE = 5;
    protected const int LUA_TFUNCTION = 6;
    protected const int LUA_TUSERDATA = 7;
    protected const int LUA_TTHREAD = 8;
    protected const int LUA_MULTRET = -1;
    protected const string LUA_INTFRMLEN = "l";

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static DynValue GetArgument(LuaState L, int pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static DynValue ArgAsType(LuaState L, int pos, DataType type, bool allowNil = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaType(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string LuaLCheckLString(LuaState L, int argNum, out uint l) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaPushInteger(LuaState L, int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaToBoolean(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string LuaToLString(LuaState luaState, int p, out uint l) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string LuaToString(LuaState luaState, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLAddValue(LuaLBuffer b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLAddLString(LuaLBuffer b, CharPtr s, uint p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLAddString(LuaLBuffer b, string s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaLOptInteger(LuaState L, int pos, int def) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaLCheckInteger(LuaState L, int pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLArgCheck(LuaState L, bool condition, int argNum, string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaLCheckInt(LuaState L, int argNum) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaGetTop(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaLError(LuaState luaState, string message, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLAddChar(LuaLBuffer b, char p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLBuffInit(LuaState L, LuaLBuffer b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaPushLiteral(LuaState L, string literalString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLPushResult(LuaLBuffer b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaPushLString(LuaState L, CharPtr s, uint len) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLCheckStack(LuaState L, int n, string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string LUA_QL(string p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaPushNil(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaAssert(bool p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string LuaLTypeName(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaIsString(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaPop(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaGetTable(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int LuaLOptInt(LuaState L, int pos, int def) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static CharPtr LuaLCheckString(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string LuaLCheckStringStr(LuaState L, int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaLArgError(LuaState L, int arg, string p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static double LuaLCheckNumber(LuaState L, int pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaPushValue(LuaState L, int arg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void LuaCall(LuaState L, int nargs, int nresults = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int memcmp(CharPtr ptr1, CharPtr ptr2, uint size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int memcmp(CharPtr ptr1, CharPtr ptr2, int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static CharPtr memchr(CharPtr ptr, char c, uint count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static CharPtr strpbrk(CharPtr str, CharPtr charset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isalpha(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool iscntrl(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isdigit(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool islower(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool ispunct(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isspace(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isupper(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isalnum(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isxdigit(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isgraph(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isalpha(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool iscntrl(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isdigit(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool islower(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool ispunct(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isspace(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isupper(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isalnum(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool isgraph(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static char tolower(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static char toupper(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static char tolower(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static char toupper(int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static CharPtr strchr(CharPtr str, char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static CharPtr strcpy(CharPtr dst, CharPtr src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static CharPtr strncpy(CharPtr dst, CharPtr src, int length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static int strlen(CharPtr str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void sprintf(CharPtr buffer, CharPtr str, params object[] argv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LuaBase() => throw null;
  }
}
