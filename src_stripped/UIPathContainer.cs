// Decompiled with JetBrains decompiler
// Type: UIPathContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

[ExecuteInEditMode]
[RequireComponent(typeof (RectTransform))]
public class UIPathContainer : MonoBehaviour
{
  private static readonly float SQRT_2;
  private static readonly float SQRT_3;
  [Tooltip("0.0 = Chordal\n0.5 = Centripetal\n1 = Uniform\n See 'Centripetal Catmull-Rom Spline' wikipedia article")]
  [Header("Path Config")]
  [FormerlySerializedAs("pathParameter")]
  [SerializeField]
  [Range(0.0f, 1f)]
  private float _pathParameter;
  [Tooltip("0 = Completely smooth line\n 1 = Completely straight lines")]
  [SerializeField]
  [Range(0.0f, 1f)]
  [FormerlySerializedAs("pathTension")]
  private float _pathTension;
  [Tooltip("If true, moving between nodes that are far away will take 'longer' than nodes close\nIf false, moving between any two nodes takes the same 'time' regardless of distance")]
  [Space]
  [FormerlySerializedAs("respectDistance")]
  [FormerlySerializedAs("_respectDistance")]
  [SerializeField]
  private bool _isDistanceRespected;
  [SerializeField]
  [FormerlySerializedAs("_runtimeCheckForChanges")]
  private bool _willCheckForRuntimeNodeChanges;
  private RectTransform _rectTransform;
  private bool _isCacheDirty;
  private List<RectTransform> _nodeTransformsCache;
  private List<UIPathContainer.SegmentNodeData> _nodeDataCache;
  private List<UIPathContainer.PathSegment> _segmentCache;
  private float _segmentCacheTotalLength;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void MarkPathDirty() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateIndicatorInRoot(
    RectTransform indicator,
    float pathValue01,
    RectTransform root,
    UIPathContainer.UpdateMode updateMode = UIPathContainer.UpdateMode.PosRotSize)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetPathTotalNodeDistance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected bool TryGetSegmentForPathValue(
    float pathValue,
    out UIPathContainer.PathSegment uiPathSegment,
    out float segmentValue01)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected bool TryGetSegmentForPathValueNormalized(
    float pathValue01,
    out UIPathContainer.PathSegment uiPathSegment,
    out float segmentValue01)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnTransformChildrenChanged() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void MarkDirtyIfNodesChanged() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateSegmentCacheIfDirty(bool force = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected static void GetChildren(
    RectTransform root,
    List<RectTransform> children,
    bool leafNodesOnly = true)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static UIPathContainer.PathVector3 PreparePathVector3(
    Vector3 p0,
    Vector3 p1,
    Vector3 p2,
    Vector3 p3,
    float alpha01,
    float tension01 = 0.0f)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static UIPathContainer.PathVector2 PreparePathVector2(
    Vector2 p0,
    Vector2 p1,
    Vector2 p2,
    Vector2 p3,
    float alpha01,
    float tension01 = 0.0f)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static UIPathContainer.PathFloat PreparePathFloat(
    float p0,
    float p1,
    float p2,
    float p3,
    float alpha01,
    float tension01 = 0.0f)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static UIPathContainer.PathFloat PreparePathAngleDegrees(
    float p0,
    float p1,
    float p2,
    float p3,
    float alpha01,
    float tension01 = 0.0f)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float ModAngleDegreesRelative(float target, float angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIPathContainer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static UIPathContainer() => throw null;

  [Flags]
  public enum UpdateMode
  {
    None = 0,
    Pos = 1,
    Rot = 2,
    Size = 4,
    Pivot = 8,
    PosRot = Pivot | Rot | Pos, // 0x0000000B
    PosRotSize = PosRot | Size, // 0x0000000F
  }

  protected struct SegmentNodeData
  {
    public Vector3 localPos;
    public Vector2 sizeDelta;
    public Vector2 pivot;
    public float localAngle;
    public float localScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SegmentNodeData(RectTransform source, RectTransform root) => throw null;
  }

  protected struct PathSegment
  {
    public float length;
    public UIPathContainer.PathVector3 rectLocalPos;
    public UIPathContainer.PathVector2 rectSizeDelta;
    public UIPathContainer.PathVector2 rectPivot;
    public UIPathContainer.PathFloat rectLocalAngle;
    public UIPathContainer.PathFloat rectLocalScale;
  }

  protected struct PathVector3
  {
    public Vector3 a;
    public Vector3 b;
    public Vector3 c;
    public Vector3 d;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 Evaluate(float t) => throw null;
  }

  protected struct PathVector2
  {
    public Vector2 a;
    public Vector2 b;
    public Vector2 c;
    public Vector2 d;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 Evaluate(float t) => throw null;
  }

  protected struct PathFloat
  {
    public float a;
    public float b;
    public float c;
    public float d;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Evaluate(float t) => throw null;
  }
}
