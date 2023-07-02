// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Grass.GrassPatchGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Grass
{
  [HelpURL("http://www.awesometech.no/index.php/grass-patch-generator")]
  public class GrassPatchGenerator : MonoBehaviour
  {
    public GrassPatchLod GrassPatchLod;
    public int PlaneCount;
    public float Size;
    public float MinScale;
    public float MaxScale;
    public float PlaneHeight;
    public float PlaneMaxHeight;
    public float PlaneWidth;
    public float PlaneMaxWidth;
    public int PlaneWidthSegments;
    public int PlaneHeightSegments;
    public int RandomSeed;
    public float MaxBendDistance;
    public float CurveOffset;
    public Material GrassMaterial;
    public Texture2D GrassTexture;
    public Material CustomMaterial;
    public float MinBendHeight;
    public AnimationCurve WindBend;
    public AnimationCurve AmbientOcclusion;
    public bool BakePhase;
    public bool BakeBend;
    public bool BakeAo;
    public bool ShowVertexColors;
    public bool GenerateBackside;
    public Color ColorTint1;
    public Color ColorTint2;
    public float RandomDarkening;
    public float RootAmbient;
    public float TextureCutoff;
    private Material _vertexColorMaterial;
    public List<ProceduralGrassPlane> GrassPlaneList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearGrassPlanes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetMeshVertexCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetMeshTriangleCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateGrassPatch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Mesh GetCombinedMesh(int lod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BuildPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BuildPrefabLod() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private LOD CreateLOD(GameObject go, float screenRelativeTransitionHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GrassPatchGenerator() => throw null;
  }
}
