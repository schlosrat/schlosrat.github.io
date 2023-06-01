// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SliderExtendedDataContainerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  [RequireComponent(typeof (SliderExtended))]
  public class SliderExtendedDataContainerManager : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler
  {
    [SerializeField]
    private CanvasGroup _displayValueCanvasGroup;
    [SerializeField]
    private float _displayTime;
    private SliderExtended _sliderExtended;
    private bool _showDisplayValueCanvasGroup;
    private float _disappearanceTime;
    private float _currentValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValueChangedEvent(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SliderExtendedDataContainerManager() => throw null;
  }
}
