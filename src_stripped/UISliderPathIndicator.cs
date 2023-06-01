// Decompiled with JetBrains decompiler
// Type: UISliderPathIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Logging;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UISliderPathIndicator : MonoBehaviour
{
  private const LogFilter LOGTAG = LogFilter.UI;
  [FormerlySerializedAs("pathContainer")]
  public UIPathContainer PathContainer;
  [FormerlySerializedAs("indicatorRoot")]
  public RectTransform IndicatorRoot;
  [FormerlySerializedAs("indicator")]
  public RectTransform Indicator;
  [SerializeField]
  private UIPathContainer.UpdateMode _updateMode;
  [Header("Path Value Source")]
  [FormerlySerializedAs("slider")]
  public SliderExtended Slider;
  private DrivenRectTransformTracker _indicatorTracker;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleSliderIndicatorRedraw() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UISliderPathIndicator() => throw null;
}
