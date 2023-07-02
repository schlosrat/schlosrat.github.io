// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.GroundMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
