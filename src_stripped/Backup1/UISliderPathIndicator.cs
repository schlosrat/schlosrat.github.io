// Decompiled with JetBrains decompiler
// Type: UISliderPathIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
