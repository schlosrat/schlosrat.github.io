// Decompiled with JetBrains decompiler
// Type: KSP.Animation.OffsetSliderSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.OAB;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  public class OffsetSliderSystem : KerbalMonoBehaviour, ISerializationCallbackReceiver, ILateUpdate
  {
    private static readonly int SLIDER_MODE_COUNT;
    [FormerlySerializedAs("sliders")]
    public OffsetSliderSystem.OffsetSliderData[] Sliders;
    public Dictionary<string, OffsetSliderSystem.OffsetSliderData> NamedSliderDictionary;
    public OffsetSliderSystem.OffsetToggleData[] Toggles;
    public Dictionary<string, OffsetSliderSystem.OffsetToggleData> NamedToggleDictionary;
    [HideInInspector]
    public ProcedurallyEditablePart ProcedurallyEditablePartReference;
    public Action PreUpdateOffset;
    public Action PostUpdateOffset;
    public Action PostUpdateMeasurements;
    [SerializeField]
    private bool initOnEnable;
    private Dictionary<Transform, List<OffsetSliderSystem.SliderTargetData>> additiveTransformDictionary;
    private List<OffsetSliderSystem.OffsetSliderData> sortedSliderUpdateList;
    private bool isInitialized;
    private bool _doTakeMeasurement;
    private StackObjectsBetweenTwoPoints _stacker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeTargetData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CollectRecursiveSliderDependencies(
      OffsetSliderSystem.OffsetSliderData curSlider,
      ref List<OffsetSliderSystem.OffsetSliderData> doneList,
      ref List<OffsetSliderSystem.OffsetSliderData> alreadyCheckedList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildHierarchySortedSliderUpdateList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleAllConstraints(bool toggleState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSliderToMatchInitialPosition(
      OffsetSliderSystem.OffsetSliderData offsetSliderData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAllOffsets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetSlidersConstainingString(string nameFilter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllSlidersToDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllSlidersToNeutral() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<int, Vector3> CalcAllOffsetsForTransform(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddEntryToAdditiveTransformDictionary(
      Transform key,
      OffsetSliderSystem.SliderTargetData value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyOffsets(
      List<OffsetSliderSystem.SliderTargetData> targetDataList,
      Dictionary<int, Vector3> newOffsets)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyOffsetByMode(
      OffsetSliderSystem.OffsetSliderMode mode,
      OffsetSliderSystem.SliderTargetData targetData,
      Vector3 newOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ISerializationCallbackReceiver.OnBeforeSerialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ISerializationCallbackReceiver.OnAfterDeserialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteSliderValues(OffsetSliderSystem target, float tolerance = 0.0001f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteToggleValues(OffsetSliderSystem target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OffsetSliderSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OffsetSliderSystem() => throw null;

    public enum OffsetSliderMode
    {
      POSITION,
      ROTATION,
      SCALE,
      CONSTRAINT_POS,
      CONSTRAINT_LOOK,
      CONSTRAINT_SCALE,
    }

    public enum OffsetSliderMeasurementMode
    {
      DISTANCE,
      DIST_X,
      DIST_Y,
      DIST_Z,
      ANGLE_X,
      ANGLE_Y,
      ANGLE_Z,
    }

    [Serializable]
    public class SliderMeasurement
    {
      public bool CanMeasure;
      public OffsetSliderSystem.OffsetSliderMeasurementMode MeasuringMode;
      [ReadOnlyUnityInspectorProperty]
      [Tooltip("Measurement in Meters or Degrees demending on mode.")]
      public double Measurement;
      public Transform StartPoint;
      public Transform EndPoint;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateMeasurement(string sliderName) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void MeasureLocalAngleOfSpecificAxis(int axisIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SliderMeasurement() => throw null;
    }

    [Serializable]
    public class OffsetSliderData
    {
      public string Name;
      [Tooltip("This is the localization Key that will be used to display the slider name in the UI")]
      public string DisplayName;
      [Tooltip("Associates this control with a group for categorization on the UI")]
      public string GroupName;
      [Tooltip("This is the localization Key that will be used to display the slider group name in the UI")]
      public string GroupDisplayName;
      [FormerlySerializedAs("sliderValue")]
      [Range(0.0f, 1f)]
      public float SliderValue;
      [ReadOnlyUnityInspectorProperty]
      public float DynamicFinalSliderValue;
      public float startValue;
      public SelectedDiscoverableMessage ValueIncreasedMessageType;
      public SelectedDiscoverableMessage ValueDecreasedMessageType;
      public SelectedDiscoverableProperty ValueProperty;
      public List<OffsetSliderSystem.DynamicSliderLimit> dynamicLimits;
      public OffsetSliderSystem.SliderTargetData[] targets;
      public OffsetSliderSystem.SliderMeasurement SliderMeasurement;
      public float neutralSliderValue;
      public Action OnSliderChanged;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetSliderValue(float newValue, bool silent = false) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetSliderValueNoEvent(float newValue) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetNeutralSliderValue(float newNeutral) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ResetSliderToNeutral() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ResetSliderToStart() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OffsetSliderData() => throw null;
    }

    [Serializable]
    public class DynamicSliderLimit
    {
      public string ParentSliderName;
      public AnimationCurve LimitCurve;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DynamicSliderLimit() => throw null;
    }

    [Serializable]
    public class SliderTargetData
    {
      [ReadOnlyUnityInspectorProperty]
      public Vector3 currentV3Offset;
      public OffsetSliderSystem.OffsetSliderMode mode;
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

    [Serializable]
    public class OffsetToggleData
    {
      [Tooltip("Associates this control with a group for categorization on the UI")]
      public string GroupName;
      [Tooltip("This is the localization Key that will be used to display the slider group name in the UI")]
      public string GroupDisplayName;
      [Tooltip("This is the Toggle Name used to sync with other Modules")]
      public string Name;
      public bool ToggleValue;
      public Action OnToggleChanged;
      public SelectedDiscoverableMessage OnEnabledMessageType;
      public SelectedDiscoverableMessage OnDisabledMessageType;
      public SelectedDiscoverableProperty ValueProperty;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetToggleValue(bool newValue) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetToggleValueNoEvent(bool newValue) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OffsetToggleData() => throw null;
    }
  }
}
