// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewObjectComponent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
