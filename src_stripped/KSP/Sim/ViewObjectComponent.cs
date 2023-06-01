// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewObjectComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public abstract class ViewObjectComponent : KerbalMonoBehaviour
  {
    protected SimulationObjectView _viewObject;

    public SimulationObjectView ViewObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void SyncTo(ObjectComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ViewObjectComponent() => throw null;
  }
}
