// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.GroundMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
