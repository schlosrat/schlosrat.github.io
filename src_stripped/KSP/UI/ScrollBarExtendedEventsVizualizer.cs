// Decompiled with JetBrains decompiler
// Type: KSP.UI.ScrollBarExtendedEventsVizualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (ScrollbarExtended))]
  public class ScrollBarExtendedEventsVizualizer : SelectableExtendedVisualizer
  {
    [Header("Scroll Handle Animations")]
    public AnimationTriggers DataAnimationTriggers;
    private ScrollbarExtended scrollbar;
    private DOTweenAnimation[] tweenAnimations;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChanged(bool isPointerDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScrollBarExtendedEventsVizualizer() => throw null;
  }
}
