// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.LineMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies
{
  public class LineMaskArea : BaseMaskArea
  {
    private LineSegment2D _line2D;
    private Vector3 _point1;
    private Vector3 _point2;
    private Vector3 _centerPoint;
    private float _width;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLineData(Vector3 point1, Vector3 point2, float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool HasVegetationTypeIndex(VegetationTypeIndex vegetationTypeIndex) => throw null;

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
    public Bounds GetMaskBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineMaskArea() => throw null;
  }
}
