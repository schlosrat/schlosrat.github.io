// Decompiled with JetBrains decompiler
// Type: KSP.Modules.WheelSubsystems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
