// Decompiled with JetBrains decompiler
// Type: ParametricLineGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Shapes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

public class ParametricLineGenerator : IDisposable
{
  public const double DEFAULT_TRIANGLE_AREA_MIN = 6.0;
  public const double DEFAULT_SCREEN_RATIO_MAX = 0.01;
  public const double DEFAULT_SQUARED_PERIMETER_SIZE_RATIO_MIN = 0.2;
  public const double DEFAULT_SQUARED_PERIMETER_MIN = 10.0;
  public const double DEFAULT_START_PARAM = 0.0;
  public const double DEFAULT_END_PARAM = 6.2831853071795862;
  public const int DEFAULT_MAX_ITERATIONS = 16;
  public const int MAX_ITERATIONS_UPPER_BOUND = 32;
  public const int MAX_POINT_COUNT_LOWER_BOUND = 32;
  public const int DEFAULT_MAX_POINT_COUNT = 128;
  public const int DEFAULT_SEED_POINTS_PER_PERIOD = 8;
  public const int SEED_POINTS_PER_PERIOD_LOWER_BOUND = 4;
  public const double RANGE_PERIOD = 6.2831853071795862;
  private bool _valuesDirty;
  private int _maxPointCount;
  private bool _rangeScalesMaxPointCount;
  private int _effectiveMaxPointCountCache;
  private int _seedPointsPerPeriod;
  private int _seedPointCountCache;
  private int _maxSeedPointsToGenerate;
  private int _maxIterations;
  private SubdivisionHeuristic _activeHeuristics;
  private double _triangleAreaMin;
  private double _triangleAreaMinViewCache;
  private double _screenSizeRatioMax;
  private double _squaredPerimeterSizeRatioMin;
  private double _squaredPerimeterMin;
  private double _squaredPerimeterMinViewCache;
  private double _startParam;
  private double _endParam;
  private double _paramRange;
  private bool _shouldGenerateLastPoint;
  private Matrix4x4D _localToWorldMatrixCache;
  private Matrix4x4D _worldToLocalMatrixCache;
  private bool _isMatrixIdentity;
  private double _postGenerationScale;
  private Camera _camera;
  private Plane[] _localCameraFrustumCache;
  private Matrix4x4 _localToCameraViewportPartialCache;
  private float _cameraFrustumHeightScalerCache;
  private readonly ParametricLineGenerator.GetParametricLocalPointDelegate _fallbackPointFunc;
  private ParametricLineGenerator.GetParametricLocalPointDelegate _parametricLocalPointFunc;
  private ParametricLineGenerator.GetParametricThicknessDelegate _parametricThicknessFunc;
  private double _defaultThickness;
  private bool _applyPostScaleToThickness;
  private ParametricLineGenerator.GetParametricColorDelegate _parametricColorFunc;
  private Color _defaultColor;
  private int usedCount;
  private NativeList<double> parameter;
  private NativeList<int> nextNodeIndex;
  private NativeList<int> finalizedInPass;
  private NativeList<Vector3d> localPoint;
  private NativeList<Vector3> viewPoint;
  private NativeList<double> thickness;
  private NativeList<Color> color;
  private NativeList<int> iteration;
  private NativeList<ParametricLineGenerator.GenerationStep> generationStep;
  public bool storeBoundsForDebug;
  private List<ParametricLineGenerator.BoundsNode> _boundsBuffer;
  private List<ParametricLineGenerator.SubdivisionPassData> _subdivisionPasses;
  private Bounds _scratchNodeSegmentBounds;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool HaveDirtyValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private bool SetWithDirty<T>(ref T toSet, T value) => throw null;

  public int MaxPointCount
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool RangeScalesMaxPointCount
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public int SeedPointsPerPeriod
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public int MaxSeedPointsToGenerate
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public int MaxIterations
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public int CurIterations
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void SetHeuristics(SubdivisionHeuristic heuristicFlag) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public bool IsHeuristicEnabled(SubdivisionHeuristic heuristicFlag) => throw null;

  public double TriangleAreaMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double ScreenSizeRatioMax
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double SquaredPerimeterSizeRatioMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double SquaredPerimeterMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double StartParam
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double EndParam
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double ParamRange
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool ShouldGenerateLastPoint
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Camera Camera
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Matrix4x4D LocalToWorldMatrix
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool IsMatrixIdentity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public double PostGenerationScale
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetLocalPointGetter(
    ParametricLineGenerator.GetParametricLocalPointDelegate localPointGetter)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d GetParametricLocalPoint(double parameter) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetThicknessGetter(
    ParametricLineGenerator.GetParametricThicknessDelegate thicknessGetter)
  {
    throw null;
  }

  public double DefaultThickness
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool ApplyPostScaleToThickness
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private double GetParametricThickness(double parameter) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetColorGetter(
    ParametricLineGenerator.GetParametricColorDelegate colorGetter)
  {
    throw null;
  }

  public Color DefaultColor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Color GetParametricColor(double parameter) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int AddNode(ParametricLineGenerator.ParametricNode node) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private ParametricLineGenerator.ParametricNode GetNodeAtIndex(int index) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private ParametricLineGenerator.ParametricNode CreateNode(double parameter, int iteration = 0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void WriteBounds(List<ParametricLineGenerator.BoundsNode> target, bool clear = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ParametricLineGenerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Dispose() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DisposeNativeArrays() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int GeneratePoints() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private void PrecomputeStuff() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private void PopulateSeedPoints() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private void SetUpSubdivisionPasses() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private void RunSubdivisionPasses() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private int SubdividePointsForScreenspace(
    int curPass,
    int curIteration,
    SubdivisionHeuristic heuristics,
    int allowedInsertions)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private ParametricLineGenerator.ParametricNode SubdivideNodeSegment(
    double curNodeParameter,
    double nextNodeParameter,
    int curIteration)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static void SetNodeSegmentBounds(
    ref Bounds bounds,
    Vector3d fromLocalPoint,
    double fromThickness,
    Vector3d toLocalPoint,
    double toThickness)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private Vector3 LocalToCameraViewport(Vector3 localPoint) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private ParametricLineGenerator.GenerationStep CheckScreenspaceHeuristics(
    Vector3 viewPoint0,
    Vector3 viewPoint1,
    Vector3 viewPoint2,
    SubdivisionHeuristic heuristics)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static float ComputeTriangleArea(Vector3 point0, Vector3 point1, Vector3 point2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static float ComputeBoundingSquareSide(Vector3 point0, Vector3 point1, Vector3 point2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static float ComputeTriangleDot(Vector3 point0, Vector3 point1, Vector3 point2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static float ComputeMaxScreenSizeRatio(
    float frustumScaler,
    float distance0,
    float distance1,
    float distance2)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static void ResizeIfNeeded<T>(List<T> target, int countToAdd) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void WritePointsLocalSpace(PolylinePath path, bool clear = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void WritePointsToLocalSpace(
    List<Vector3> localPoints,
    List<double> parameters,
    bool clear = true)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void WritePointsWorldSpace(PolylinePath path, bool clear = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void DebugWriteSingleData<T>(
    List<T> target,
    Func<ParametricLineGenerator.ParametricNode, T> getter,
    bool clear = true)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void ForEach(
    Action<ParametricLineGenerator.ParametricNode, int> callback)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static double Clamp(double value, double min, double max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private static double Clamp01(double value) => throw null;

  public delegate Vector3d GetParametricLocalPointDelegate(double parameter);

  public delegate double GetParametricThicknessDelegate(double parameter);

  public delegate Color GetParametricColorDelegate(double parameter);

  public enum GenerationStep
  {
    Failed = -1, // 0xFFFFFFFF
    Seed = 0,
    TriangleArea = 1,
    ScreenSizeRatio = 2,
    SquaredPerimeter = 3,
  }

  public struct ParametricNode
  {
    public double parameter;
    public int nextNodeIndex;
    public int finalizedInPass;
    public Vector3d localPoint;
    public Vector3 viewPoint;
    public double thickness;
    public Color color;
    public int iteration;
    public ParametricLineGenerator.GenerationStep generationStep;
  }

  public struct BoundsNode
  {
    public Bounds bounds;
    public int iteration;
    public bool hadHit;
    public int fromNodeIndex;
    public int toNodeIndex;
  }

  private struct SubdivisionPassData
  {
    public SubdivisionHeuristic heuristicsInPass;
    public int insertBudget;
    public int totalIterations;
    public int totalInserts;
  }
}
