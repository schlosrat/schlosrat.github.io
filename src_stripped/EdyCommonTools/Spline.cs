// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.Spline
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EdyCommonTools
{
  public class Spline : MonoBehaviour
  {
    [FormerlySerializedAs("type")]
    public Spline.Tangents tangents;
    [Range(0.0f, 1f)]
    public float a;
    [Range(-1f, 1f)]
    public float t;
    [Range(-1f, 1f)]
    public float c;
    [Range(-1f, 1f)]
    public float b;
    public bool closed;
    [FormerlySerializedAs("uniform")]
    public bool soften;
    public Spline.Point[] points;
    [Range(1f, 100f)]
    public int resolution;
    public bool enableGizmos;
    public bool showSpline;
    public Color splineColor;
    public bool showPoints;
    [Range(0.0f, 1f)]
    public float pointRadius;
    public Color pointColor;
    public bool showMarkers;
    public Spline.MarkersMode markersMode;
    [Range(0.0f, 2f)]
    public float markersLength;
    public float markersInterval;
    public bool showNormals;
    public Color normalsColor;
    public bool showTangents;
    public bool showArrows;
    [Range(0.1f, 1f)]
    public float tangentScale;
    public bool showProjection;
    public Spline.ProjectionMode projectionMode;
    public Color projectionColor;
    public float projectionY;
    public float projectionMaxY;
    public float projectionMinY;
    public LayerMask projectionCollisionMask;
    public bool showDebugElements;
    public bool enableLabels;
    public bool identifiers;
    public bool segmentLength;
    public bool pointDistance;
    public bool projectionHeight;
    public bool disablePrecomputedData;
    public int defaultBroadPhaseResolution;
    public int defaultMaxDetailSegments;
    public float defaultDetailPrecision;
    private float m_length;
    private int m_precompDataSize;
    private int m_samplingCount;
    private List<Spline.BroadPhaseData> m_defaultBroadPhaseBuffer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    public bool isClosed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int precomputedDataSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int segments
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int samplingCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float DistanceToPosition(float distance, Spline.WrapMode wrapMode = Spline.WrapMode.Clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPosition(float s, Spline.WrapMode wrapMode = Spline.WrapMode.Clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetTangent(float s, Spline.WrapMode wrapMode = Spline.WrapMode.Clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetNormal(float s, Vector3 up, Spline.WrapMode wrapMode = Spline.WrapMode.Clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetBinormal(float s, Vector3 up, Spline.WrapMode wrapMode = Spline.WrapMode.Clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPosition(float s, out Vector3 tangent, Spline.WrapMode wrapMode = Spline.WrapMode.Clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPosition(
      float s,
      out Vector3 tangent,
      out Vector3 normal,
      Vector3 up,
      Spline.WrapMode wrapMode = Spline.WrapMode.Clamp)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float MeasureDistance(float s0, float s1, Spline.WrapMode wrapMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ComputeDistance(float s0, float s1, Spline.WrapMode wrapMode = Spline.WrapMode.Clamp, int steps = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Project(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Project(
      Vector3 worldPosition,
      List<Spline.BroadPhaseData> broadPhaseBuffer,
      int broadPhaseResolution = 5,
      int maxDetailSegments = 2,
      float detailPrecision = 0.001f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SplitPosition(
      float s,
      Spline.WrapMode wrapMode,
      out int i0,
      out int i1,
      out float s0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPositionInSegment(Spline.Point p0, Spline.Point p1, float s0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetTangentInSegment(Spline.Point p0, Spline.Point p1, float s0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetSafeTangentInSegment(
      Spline.Point p0,
      Spline.Point p1,
      float s0,
      float threshold = 0.002f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float MeasureDistanceInSegment(Spline.Point p0, Spline.Point p1, float s0, float s1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ComputePartialSegmentLength(
      Spline.Point p0,
      Spline.Point p1,
      float s1,
      int steps)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIterationSteps(float s0, float s1, int resolutionPerSegment, int minResolution = 1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetSegmentResolutionAdaptive(
      float segmentLength,
      float resolutionPerDistance,
      int minResolution = 1)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetSegmentResolutionProportional(
      float segmentLength,
      int proportionalResolution,
      int minResolution = 1)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ComputeProjectionBroadPhase(
      List<Spline.BroadPhaseData> results,
      Vector3 worldPos,
      int proportionalResolution)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ComputeProjectionDetailPhase(
      List<Spline.BroadPhaseData> results,
      Vector3 worldPos,
      int maxSegments,
      float precision)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ClosestPointToSegment(
      Spline.Point p0,
      Spline.Point p1,
      Vector3 worldPos,
      int segmentResolution)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float BisectByTangentInSubsegment(
      Spline.Point p0,
      Spline.Point p1,
      Vector3 worldPos,
      float s0 = 0.0f,
      float s1 = 1f,
      float precision = 0.001f,
      int maxIterations = 30)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SplitPositionClamp(float s, out int i0, out int i1, out float s0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SplitPositionRepeat(float s, out int i0, out int i1, out float s0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SplitPositionPingPong(float s, out int i0, out int i1, out float s0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetPositionPoints(
      float s,
      Spline.WrapMode wrapMode,
      out Spline.Point p0,
      out Spline.Point p1)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ClampValue(float value, float max, Spline.WrapMode wrapMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetNonZeroOutTangentInPoint(int i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeTangentsCardinalOpen(float _a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeTangentsCardinalClosed(float _a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeTangentsTCBOpen() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeTangentsTCBClosed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearTangents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UniformizeTangents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeSplineProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeSegmentProperties(Spline.Point p0, Spline.Point p1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrecomputeSplineData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrecomputeSegmentData(Spline.Point p0, Spline.Point p1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeSegmentDistanceToPosition(Spline.Point p0, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float Interpolate(float[] values, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeDistanceGeneric(float s0, float s1, Spline.WrapMode wrapMode, int steps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeDistanceRepeatOpen(float s0, float s1, int steps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ImportFromCsvFile(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetProjectedPoint(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSplineGizmo(Spline.Point p0, Spline.Point p1, Color col, bool projected = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawProjectedPointGizmo(Spline.Point p0, float radius, Color col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawIncomingTangentGizmo(Spline.Point p0, Color col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawOutcomingTangentGizmo(Spline.Point p0, Color col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPointGizmo(Spline.Point p0, float radius, Color col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSpineMarker(float s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSegmentCrossMark(Spline.Point p0, Spline.Point p1, float s, float length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPoint(Spline.Point p0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSpline(Spline.Point p0, Spline.Point p1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Spline() => throw null;

    public enum Tangents
    {
      Cardinal,
      TCB,
      Custom,
    }

    [Serializable]
    public class Point
    {
      public Vector3 position;
      public Vector3 customInTangent;
      public Vector3 customOutTangent;
      [NonSerialized]
      public Vector3 inTangent;
      [NonSerialized]
      public Vector3 outTangent;
      [NonSerialized]
      public float segmentLength;
      [NonSerialized]
      public float splineDistance;
      [NonSerialized]
      public float[] direct;
      [NonSerialized]
      public float[] inverse;
      [NonSerialized]
      public Bounds bounds;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Point() => throw null;
    }

    public enum MarkersMode
    {
      Points,
      Spline,
      Uniform,
      Interval,
    }

    public enum ProjectionMode
    {
      XZPlane,
      Colliders,
    }

    [DebuggerDisplay("{DebuggerDisplay(),nq}")]
    public struct BroadPhaseData : IComparable<Spline.BroadPhaseData>
    {
      public int segment;
      public float s;
      public float distance;
      public float error;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int CompareTo(Spline.BroadPhaseData other) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private string DebuggerDisplay() => throw null;
    }

    public enum WrapMode
    {
      Clamp,
      Repeat,
      PingPong,
    }
  }
}
