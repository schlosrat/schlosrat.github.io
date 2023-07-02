// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SliderExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class SliderExtended : Slider, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
  {
    [NonReorderable]
    public AK.Wwise.Event[] OnSliderStartedAudioEvents;
    [NonReorderable]
    public AK.Wwise.Event[] OnSliderFinishedAudioEvents;
    public TextMeshProUGUI TextLabelTop;
    public TextMeshProUGUI TextLabelBottom;
    public bool DisplayTopText;
    public bool DisplayBottomText;
    [Space]
    public bool PublishMessages;
    public SelectedDiscoverableMessage SliderReleasedMessageType;
    private CanvasGroup canvasGroupLabelTop;
    private CanvasGroup canvasGroupLabelBottom;
    public readonly SliderExtended.IsPointerDownChangedEvent onIsPointerDownChanged;
    public readonly SliderExtended.DragPositionChangedEvent onDragPositionChanged;
    public readonly SliderExtended.OnValueChangeWithoutPointer onValueDiffWithoutPointer;
    public readonly UnityEvent onSliderVisualUpdated;
    private float _lastSetValue;
    private bool _isAudioLoopStarted;

    public bool IsPointerDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWithoutCallback(float newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateCachedReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnRectTransformDimensionsChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoStateTransition(Selectable.SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Set(float newValue, bool sendCallback = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleSetWithCallback(float newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshLabelVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDidApplyAnimationProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PostAKEventsWithPositionalRTPC(AK.Wwise.Event[] EventsToPost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SliderExtended() => throw null;

    public class IsPointerDownChangedEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public IsPointerDownChangedEvent() => throw null;
    }

    public class DragPositionChangedEvent : UnityEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragPositionChangedEvent() => throw null;
    }

    public class OnValueChangeWithoutPointer : UnityEvent<float>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public OnValueChangeWithoutPointer() => throw null;
    }
  }
}
