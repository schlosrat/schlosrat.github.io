// Decompiled with JetBrains decompiler
// Type: OffsetSliders
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Inspector;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class OffsetSliders : MonoBehaviour
{
  public OffsetSliders.SliderData[] sliders;
  public Action PreUpdateOffset;
  public Action PostUpdateOffset;
  private Dictionary<Transform, List<OffsetSliders.SliderTargetData>> additiveTransformDictionary;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitializeTargetData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSliderToMatchInitialPosition(OffsetSliders.SliderData sliderData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateAllOffsets() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetFlaps() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetAllSliders() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Dictionary<int, Vector3> CalcAllOffsetsForTransform(Transform targetTransform) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddEntryToAdditiveTransformDictionary(
    Transform key,
    OffsetSliders.SliderTargetData value)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ApplyOffsets(
    List<OffsetSliders.SliderTargetData> targetDataList,
    Dictionary<int, Vector3> newOffsets)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ApplyOffsetByMode(
    OffsetSliders.OffsetSliderMode mode,
    OffsetSliders.SliderTargetData targetData,
    Vector3 newOffset)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OffsetSliders() => throw null;

  public enum OffsetSliderMode
  {
    POSITION,
    ROTATION,
    SCALE,
    CONSTRAINT_POS,
    CONSTRAINT_LOOK,
  }

  [Serializable]
  public class SliderData
  {
    public string Name;
    [Range(0.0f, 1f)]
    public float sliderValue;
    public OffsetSliders.SliderTargetData[] targets;
    public Action OnSliderChanged;
    private float originalValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderValue(float newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOriginalValue(float startValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetSlider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SliderData() => throw null;
  }

  [Serializable]
  public class SliderTargetData
  {
    [ReadOnly]
    public Vector3 currentV3Offset;
    public OffsetSliders.OffsetSliderMode mode;
    public Transform target;
    public Vector3 MinV3;
    public Vector3 MaxV3;
    [HideInInspector]
    public Vector3 originalV3;
    [HideInInspector]
    public IConstraint constraint;

    [HideInInspector]
    public Vector3 differenceV3
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateOriginalValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateOffset(float percentage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SliderTargetData() => throw null;
  }
}
