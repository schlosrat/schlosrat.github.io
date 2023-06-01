// Decompiled with JetBrains decompiler
// Type: KSP.Modules.WheelSubsystems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  public class WheelSubsystems
  {
    private List<WheelSubsystem> subs;
    private WheelSubsystem.SystemTypes types;
    public Callback<WheelSubsystems> OnModified;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WheelSubsystems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSubsystem(WheelSubsystem d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveSubsystem(WheelSubsystem d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasType(WheelSubsystem.SystemTypes t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(WheelSubsystem s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetReasons(ref string o, string separator = ", ") => throw null;
  }
}
