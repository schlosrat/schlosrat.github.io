// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BeaconMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies
{
  public class BeaconMaskArea : BaseMaskArea
  {
    public float Radius;
    public Vector3 Position;
    public NativeArray<float> FalloutCurveArray;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFalloutCurve(float[] curveArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JobHandle SampleMask(
      VegetationInstanceData instanceData,
      VegetationType vegetationType,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JobHandle SampleIncludeVegetationMask(
      VegetationInstanceData instanceData,
      VegetationTypeIndex vegetationTypeIndex,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool HasVegetationTypeIndex(VegetationTypeIndex vegetationTypeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds GetMaskBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BeaconMaskArea() => throw null;
  }
}
