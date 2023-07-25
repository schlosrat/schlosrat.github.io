// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.GroundMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
