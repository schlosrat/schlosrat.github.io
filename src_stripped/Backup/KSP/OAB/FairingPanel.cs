// Decompiled with JetBrains decompiler
// Type: KSP.OAB.FairingPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class FairingPanel
  {
    public GameObject PanelGameObject;
    public int PanelIndex;
    public Mesh Mesh;
    public Material Material;
    public GameObject ColliderContainer;
    public bool IsCap;
    public bool IsLast;
    public FairingCrossSection Bottom;
    public FairingCrossSection Top;
    [NonSerialized]
    private MeshFilter _meshFilter;
    [NonSerialized]
    private MeshRenderer _meshRenderer;
    [NonSerialized]
    private FairingPanel _topNeighbour;
    [NonSerialized]
    private FairingPanel _bottomNeighbour;
    private float _arcFrom;
    private float _arcTo;
    private Data_Fairing _hostData;
    private Vector3 _pivotOffset;
    private Vector3 _explodedPos;
    private int _amountOfSides;
    private int _pointCount;
    private MeshPoint[] _points;
    private List<int> _triangles;
    private Quaternion _slope;
    private MeshArc[] _meshArcs;
    private FairingPanel _previousPanel;
    public static float UTILING;

    public Vector3 PivotOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 ExplodedPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsSection(FairingCrossSection sec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<FairingPanel> SetupPanelArray(
      int nSegments,
      Material FairingMaterial,
      Material FairingConeMaterial,
      List<FairingCrossSection> xSections,
      Data_Fairing hostData,
      float capRadius,
      bool offsetStartHeight = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingPanel(
      FairingCrossSection[] xSections,
      Material mat,
      float arcFrom,
      float arcTo,
      Data_Fairing host)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Spawn(Transform trf, bool isOAB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Despawn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInterpolations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSlope() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BuildMesh(
      bool triangulate,
      FairingPanel prevPanel,
      int panelArcNum,
      int totalPanels)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetBarycenter(MeshPoint[] pts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void AssignMesh(
      Mesh m,
      MeshPoint[] pts,
      List<int> tris,
      Vector3 pivotOffset,
      bool triangulate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetArcPivot(MeshArc arc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetPanelSlope(MeshArc bottom, MeshArc top, ref Quaternion slope) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetPanelHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetBaseHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetMidPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static float[] SetArcPoints(
      Vector3 pivot,
      Vector3 axis,
      Vector3 v0,
      Vector3 n0,
      Quaternion slope,
      float fromAngle,
      float toAngle,
      float radius,
      float h,
      float uOffset,
      float uTiling,
      Color vColor,
      ref MeshPoint[] arcPoints,
      float[] prevH,
      MeshPoint[] prevPoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int SetPanelMeshPoints(
      ref MeshPoint[] pts,
      ref MeshPoint[] arc,
      int ptsOffset,
      bool aberrantNormals)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TriangulatePanelMesh(
      MeshPoint[] bottomArcOuter,
      MeshPoint[] topArcOuter,
      MeshPoint[] bottomArcInner,
      MeshPoint[] topArcInner,
      int nSides,
      bool capTop,
      bool capBottom,
      List<int> tris)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TriangulateQuad(int v00, int v01, int v0, int v1, List<int> tris) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SetNoseConePoints(
      Vector3 pivot,
      Vector3 axis,
      Vector3 n0,
      float radius,
      float uOffset,
      ref MeshPoint[] pts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TriangulateConePanel(
      MeshPoint[] bottomArcOuter,
      MeshPoint[] topArcOuter,
      MeshPoint[] bottomArcInner,
      MeshPoint[] topArcInner,
      bool capTop,
      bool capBottom,
      List<int> tris)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TriangulateTriangleMesh(
      MeshPoint[] arcOuter,
      MeshPoint[] arcInner,
      int nSidesOuter,
      int nSidesInner,
      List<int> tris,
      bool flip)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void TriangulateTri(int v00, int v0, int v1, List<int> tris, bool flip) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void LazyInitMeshArray(ref MeshPoint[] mArray, int length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetArea() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bounds GetBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4 GetUVBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetCursorProximity(Vector3 cursorPosition, float range, Camera referenceCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCollapsedViewInstantly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GeneratePanelColliders(GameObject hostGo, int layer, bool isTrigger) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateCompoundColliders(
      GameObject hostGo,
      MeshArc bottomArc,
      MeshArc topArc,
      bool triangulate,
      int layer,
      bool isTrigger)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateConvexMesh(GameObject hostGo, int layer, bool isTrigger) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMeshGutters(Vector4 minmaxUVs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPreviousPanel(FairingPanel panel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPanelAlternateColor(Module_Color moduleColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPanelMainColor(Module_Color moduleColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FairingPanel() => throw null;
  }
}
