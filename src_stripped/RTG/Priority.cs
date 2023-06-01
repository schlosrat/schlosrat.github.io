// Decompiled with JetBrains decompiler
// Type: RTG.Priority
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class Priority
  {
    private int _priority;

    public int Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static int Lowest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static int Highest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeLowest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeHighest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeLowerThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeHigherThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(Priority other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(Priority firstPriority, Priority secondPriority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(Priority firstPriority, Priority secondPriority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator >(Priority firstPriority, Priority secondPriority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator >=(Priority firstPriority, Priority secondPriority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator <(Priority firstPriority, Priority secondPriority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator <=(Priority firstPriority, Priority secondPriority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Priority() => throw null;
  }
}
