// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Debugging.SourceRef
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Debugging
{
  public class SourceRef
  {
    public bool Breakpoint;

    public bool IsClrLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int SourceIdx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int FromChar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int ToChar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int FromLine
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int ToLine
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsStepStop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool CannotBreakpoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static SourceRef GetClrLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SourceRef(SourceRef src, bool isStepStop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SourceRef(int sourceIdx, int from, int to, int fromline, int toline, bool isStepStop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int GetLocationDistance(int sourceIdx, int line, int col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IncludesLocation(int sourceIdx, int line, int col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SourceRef SetNoBreakPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string FormatLocation(Script script, bool forceClassicFormat = false) => throw null;
  }
}
