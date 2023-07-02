// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewObjectComponent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public abstract class ViewObjectComponent<T> : ViewObjectComponent where T : ObjectComponent
  {
    protected T _simObjectComponent;

    public T SimObjectComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(ObjectComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void SyncTo(T simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSimObjectDestroyed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ViewObjectComponent() => throw null;
  }
}
