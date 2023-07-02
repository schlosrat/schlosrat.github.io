// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.SliderTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace KSP.Navigation
{
  [RequireComponent(typeof (NavElementTag))]
  [DisallowMultipleComponent]
  public class SliderTag : KerbalMonoBehaviour, IPointerClickHandler, IEventSystemHandler
  {
    [Header("ERR range of zero")]
    public float DeadZone;
    [Header("Slider parameters")]
    public float HoldPointSeconds;
    public float IntervalSeconds;
    public float DeltaValue;
    private float _valuePrev;
    private Slider _slider;
    private bool _isFocused;

    public Slider TargetSlider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool Focused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool positive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool negative
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindInputs(bool isBind) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AlterValueRoutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AlterValue(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Submit(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cancel(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SliderTag() => throw null;
  }
}
