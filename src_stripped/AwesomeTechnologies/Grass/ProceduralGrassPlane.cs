// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Grass.ProceduralGrassPlane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Grass
{
  [RequireComponent(typeof (MeshFilter))]
  [RequireComponent(typeof (MeshRenderer))]
  [Serializable]
  public class ProceduralGrassPlane : MonoBehaviour
  {
    public int widthSegments;
    public int heightSegments;
    public float width;
    public float height;
    public ProceduralGrassPlane.AnchorPoint anchor;
    private Vector2 anchorOffset;
    public float Offset1;
    public float Offset2;
    public float MinimumBendHeight;
    public float CurveOffset;
    public int LODLevel;
    public Material Material;
    public bool BakePhase;
    public bool BakeBend;
    public bool BakeAO;
    public float Phase;
    public AnimationCurve BendCurve;
    public AnimationCurve AmbientOcclusionCurve;
    public bool GenerateBackside;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAncorPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPhaseAndBend(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateGrassPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildBackside(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralGrassPlane() => throw null;

    public enum AnchorPoint
    {
      TopLeft,
      TopHalf,
      TopRight,
      RightHalf,
      BottomRight,
      BottomHalf,
      BottomLeft,
      LeftHalf,
      Center,
    }
  }
}
