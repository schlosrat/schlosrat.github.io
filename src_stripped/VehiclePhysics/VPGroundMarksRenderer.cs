// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundMarksRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Marks Renderer")]
  public class VPGroundMarksRenderer : MonoBehaviour
  {
    public VPGroundMarksRenderer.Mode mode;
    [Range(0.0f, 1f)]
    public float pressureBoost;
    [Space(5f)]
    public int maxMarks;
    public float minDistance;
    public float groundOffset;
    public float textureOffsetY;
    [Range(0.0f, 1f)]
    public float fadeOutRange;
    public Material material;
    private Transform m_transform;
    private int m_markCount;
    private int m_markArraySize;
    private MarkPoint[] m_markPoints;
    private BiasedRatio m_pressureRatioBias;
    private bool m_segmentsUpdated;
    private int m_segmentCount;
    private int m_segmentArraySize;
    private Mesh m_mesh;
    private Vector3[] m_vertices;
    private Vector3[] m_normals;
    private Vector4[] m_tangents;
    private Color[] m_colors;
    private Vector2[] m_uvs;
    private int[] m_triangles;
    private Vector2[] m_values;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int AddMark(
      Vector3 pos,
      Vector3 normal,
      float pressureRatio,
      float skidRatio,
      float width,
      int lastIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSegment(MarkPoint first, MarkPoint second) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPGroundMarksRenderer() => throw null;

    public enum Mode
    {
      PressureAndSkid,
      PressureOnly,
    }
  }
}
