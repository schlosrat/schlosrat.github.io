// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.GroundMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [Serializable]
  public class GroundMaterial
  {
    public PhysicMaterial physicMaterial;
    public float grip;
    public float drag;
    public VPGroundMarksRenderer marksRenderer;
    public VPGroundParticleEmitter particleEmitter;
    public VPGroundRumbleEffect rumbleEffect;
    public GroundMaterial.SurfaceType surfaceType;
    public object customData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GroundMaterial() => throw null;

    public enum SurfaceType
    {
      Hard,
      Soft,
      Neutral,
    }
  }
}
