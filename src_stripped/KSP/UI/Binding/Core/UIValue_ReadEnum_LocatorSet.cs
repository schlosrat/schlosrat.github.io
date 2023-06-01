// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_LocatorSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValue_ReadEnum_LocatorSet : UIValueEnumBinder
  {
    [SerializeField]
    private RectTransform indicator;
    [Header("Animation parameters")]
    [SerializeField]
    private float animationDuration;
    [SerializeField]
    private AnimationCurve animationCurve;
    [Header("MODE SELECT")]
    [SerializeField]
    [Tooltip("MoveIndicatorToLocators: The indicator is moved to each Locator. Can optionally also rescale the indicator\n\nPointIndicatorAtLocators: The indicator is rotated around the Z axis to point at each Locator\n\nMoveLocatorsToIndicator: The locator root is moved to position each Locator over the indicator\n\n")]
    private UIValue_ReadEnum_LocatorSet.IndicatorMode indicatorMode;
    [SerializeField]
    [Header("MODE: Move Indicator To Locators")]
    private bool animateSize;
    [SerializeField]
    [Tooltip("Must be parent of the Locators")]
    [Header("MODE: Move Locators To Indicator")]
    private RectTransform locatorRoot;
    [SerializeField]
    [Header("Value locators")]
    private List<UIValue_ReadEnum_LocatorSet.SlidingLocatorEntry> locators;
    [SerializeField]
    [Header("Optional")]
    [Tooltip("This is used when the current value is not mapped")]
    private RectTransform fallbackLocator;
    private Dictionary<string, RectTransform> valueMap;
    protected Coroutine moveAnimation;
    protected Coroutine pointAnimation;
    protected Coroutine moveLocatorRootAnimation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void MoveIndicatorToLocator(RectTransform locator, float duration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual IEnumerator AnimateMoveIndicatorToLocator(
      RectTransform locator,
      float duration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PointIndicatorAtLocator(RectTransform locator, float duration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual float GetIndicatorAngleToLocator(RectTransform locator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual float GetIndicatorAngleToLocator(RectTransform target, Vector3 locatorOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetIndicatorAngle(float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual float GetIndicatorAngle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual IEnumerator AnimatePointIndicatorAtLocator(
      RectTransform locator,
      float duration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void MoveLocatorRoot(RectTransform locator, float duration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual IEnumerator AnimateMoveLocatorRoot(RectTransform locator, float duration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_LocatorSet() => throw null;

    private enum IndicatorMode
    {
      MoveIndicatorToLocators,
      PointIndicatorAtLocators,
      MoveLocatorsToIndicator,
    }

    [Serializable]
    public struct SlidingLocatorEntry
    {
      public string enumValue;
      public RectTransform locator;
    }
  }
}
