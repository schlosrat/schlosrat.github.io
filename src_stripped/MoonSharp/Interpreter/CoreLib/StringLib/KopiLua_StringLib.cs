// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.StringLib.KopiLua_StringLib
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.LuaStateInterop;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib.StringLib
{
  internal class KopiLua_StringLib : LuaBase
  {
    public const int LUA_MAXCAPTURES = 32;
    public const int CAP_UNFINISHED = -1;
    public const int CAP_POSITION = -2;
    public const int MAXCCALLS = 200;
    public const char L_ESC = '%';
    public const string SPECIALS = "^$*+?.([%-";
    public const int MAX_ITEM = 512;
    public const string FLAGS = "-+ #0";
    public static readonly int MAX_FORMAT;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int posrelat(int pos, uint len) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int check_capture(KopiLua_StringLib.MatchState ms, int l) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int capture_to_close(KopiLua_StringLib.MatchState ms) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr classend(KopiLua_StringLib.MatchState ms, CharPtr p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int match_class(char c, char cl) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int matchbracketclass(int c, CharPtr p, CharPtr ec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int singlematch(int c, CharPtr p, CharPtr ep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr matchbalance(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr max_expand(
      KopiLua_StringLib.MatchState ms,
      CharPtr s,
      CharPtr p,
      CharPtr ep)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr min_expand(
      KopiLua_StringLib.MatchState ms,
      CharPtr s,
      CharPtr p,
      CharPtr ep)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr start_capture(
      KopiLua_StringLib.MatchState ms,
      CharPtr s,
      CharPtr p,
      int what)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr end_capture(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr match_capture(KopiLua_StringLib.MatchState ms, CharPtr s, int l) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr match(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr lmemfind(CharPtr s1, uint l1, CharPtr s2, uint l2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void push_onecapture(
      KopiLua_StringLib.MatchState ms,
      int i,
      CharPtr s,
      CharPtr e)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int push_captures(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int str_find_aux(LuaState L, int find) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int str_find(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int str_match(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int gmatch_aux(LuaState L, KopiLua_StringLib.GMatchAuxData auxdata) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue gmatch_aux_2(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int str_gmatch(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int gfind_nodef(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void add_s(KopiLua_StringLib.MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void add_value(
      KopiLua_StringLib.MatchState ms,
      LuaLBuffer b,
      CharPtr s,
      CharPtr e)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int str_gsub(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void addquoted(LuaState L, LuaLBuffer b, int arg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CharPtr scanformat(LuaState L, CharPtr strfrmt, CharPtr form) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void addintlen(CharPtr form) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int str_format(LuaState L) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string PatchPattern(string charPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KopiLua_StringLib() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KopiLua_StringLib() => throw null;

    public class MatchState
    {
      public int matchdepth;
      public CharPtr src_init;
      public CharPtr src_end;
      public LuaState L;
      public int level;
      public KopiLua_StringLib.MatchState.capture_[] capture;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public MatchState() => throw null;

      public class capture_
      {
        public CharPtr init;
        public int len;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public capture_() => throw null;
      }
    }

    private class GMatchAuxData
    {
      public CharPtr S;
      public CharPtr P;
      public uint LS;
      public uint POS;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GMatchAuxData() => throw null;
    }
  }
}
