// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXContextualEventParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class FXContextualEventParams
  {
    public Transform SourceTransform;
    public Vector3 SourcePosition;
    public Quaternion SourceRotation;
    public PartBehavior SourcePartBehavior;
    public double PartExplosionPotential;
    public PQS Pqs;
    public SurfaceColliderData SurfaceData;
    public VFXSurfaceType SurfaceType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXContextualEventParams(
      Transform transform,
      Vector3 pos,
      Quaternion rotation,
      PartBehavior source,
      double impact,
      PQS pqs,
      SurfaceColliderData data)
    {
      throw null;
    }
  }
}
