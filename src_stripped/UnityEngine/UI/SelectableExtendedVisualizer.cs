// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SelectableExtendedVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AK.Wwise;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  public class SelectableExtendedVisualizer : TransitionVisualizerBase
  {
    public TransitionVisualSingle[] transitionVisuals;
    public bool disableAudio;
    [NonReorderable]
    public Event[] OnButtonPressedEvents;
    [NonReorderable]
    public Event[] OnButtonHoverEvents;
    public Image SelectableGraphic;
    public Sprite HighlightedSprite;
    public Sprite PressedSprite;
    public Sprite SelectedSprite;
    public Sprite DisabledSprite;
    [HideInInspector]
    public Sprite NormalSprite;
    [HideInInspector]
    public System.Type gameEventOnPressed;
    [HideInInspector]
    public int gameEventOnPressedIndex;
    private uint _rtpcX;
    private uint _rtpcY;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleStateTransition(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ChangeGraphicOnStateTransition(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSelectableGraphic(Sprite inSprite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PlayAudioEventsOnStateTransition(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void RemoveStateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected uint GetRTCPIDX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected uint GetRTCPIDY() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PostAKEventsWithPositionalRTPC(Event[] EventsToPost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool HasOnClickAudioEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool HasOnHoverAudioEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectableExtendedVisualizer() => throw null;
  }
}
