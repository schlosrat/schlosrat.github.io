// Decompiled with JetBrains decompiler
// Type: UISliderPathIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UISliderPathIndicator : MonoBehaviour
{
  private const LogFilter LOGTAG = (LogFilter) 2097152;
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
