// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.StringLib.StringRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib.StringLib
{
  internal class StringRange
  {
    public int Start
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int End
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringRange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringRange(int start, int end) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static StringRange FromLuaRange(DynValue start, DynValue end, int? defaultEnd = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ApplyToString(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Length() => throw null;
  }
}
