// Decompiled with JetBrains decompiler
// Type: ArrowPointer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class ArrowPointer : MonoBehaviour
{
  private Vector3 offset;
  private Vector3 direction;
  private float length;
  private Color color;
  private bool worldSpace;
  private Transform parent;
  private MeshFilter mf;
  private MeshRenderer mr;
  private Mesh mesh;
  private Vector3[] vertices;
  private Color32[] vertexColors;
  private bool vertexColorsRequireUpdate;
  private bool verticesRequireUpdate;

  public Vector3 Offset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 Direction
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float Length
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Color Color
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool WorldSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static ArrowPointer Create(
    Transform parent,
    Vector3 offset,
    Vector3 direction,
    float length,
    Color color,
    bool worldSpace)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateMesh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateVerts(Vector3 offset, Vector3 direction, float length, bool worldSpace) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateVertexColors(Color32 color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ArrowPointer() => throw null;
}
