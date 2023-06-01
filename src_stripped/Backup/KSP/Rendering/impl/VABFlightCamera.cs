// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.VABFlightCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Rendering.impl
{
  public class VABFlightCamera : TransformModel, ICameraShotProvider
  {
    private ICameraShot _shot;

    public ICameraShot Shot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VABFlightCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GrabObserver(IUniverseObserver observer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate(UniverseCameraManager manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate(UniverseCameraManager manager) => throw null;
  }
}
