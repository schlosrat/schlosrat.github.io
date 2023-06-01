// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SelectableExtendedVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  public class SelectableExtendedVisualizer : TransitionVisualizerBase
  {
    public TransitionVisualSingle[] transitionVisuals;
    public bool disableAudio;
    [NonReorderable]
    public AK.Wwise.Event[] OnButtonPressedEvents;
    [NonReorderable]
    public AK.Wwise.Event[] OnButtonHoverEvents;
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
    protected void PostAKEventsWithPositionalRTPC(AK.Wwise.Event[] EventsToPost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool HasOnClickAudioEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool HasOnHoverAudioEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectableExtendedVisualizer() => throw null;
  }
}
