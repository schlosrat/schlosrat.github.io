// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.FreeFlightCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Rendering.impl
{
  public class FreeFlightCamera : TransformModel, ICameraShotProvider
  {
    private ICameraShot _shot;

    public ICameraShot Shot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FreeFlightCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GrabObserver(IUniverseObserver observer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate(UniverseCameraManager manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate(UniverseCameraManager manager) => throw null;
  }
}
