// Decompiled with JetBrains decompiler
// Type: KSP.UI.AnimateToggleSwitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class AnimateToggleSwitch : KerbalMonoBehaviour
  {
    [SerializeField]
    private RectTransform toggleSwitch;
    [SerializeField]
    private RectTransform targetRect;
    [SerializeField]
    private ToggleExtended toggle;
    [SerializeField]
    private float animationTime;
    [Header("Animations")]
    [SerializeField]
    private DOTweenAnimation _toggleOn;
    [SerializeField]
    private DOTweenAnimation _toggleOff;
    private float _offPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleValueChanged(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChanged(SelectionState newState, bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleToggleAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OffAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnimateToggleSwitch() => throw null;
  }
}
