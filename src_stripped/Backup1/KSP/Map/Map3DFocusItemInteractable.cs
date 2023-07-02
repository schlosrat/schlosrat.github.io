// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DFocusItemInteractable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.UI;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Map
{
  public class Map3DFocusItemInteractable : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler,
    IPointerUpHandler,
    ITooltipTarget
  {
    [SerializeField]
    private Map3DFocusItemTooltip _tooltipObject;
    private Map3DFocusItemTooltip _currentTooltip;
    [SerializeField]
    private int _priority;
    public Color normalColor;
    public Color hoverColor;
    [Range(0.0f, 1f)]
    public float alphaModifier;
    private float lastMousePrimaryClickTime;
    private Renderer visualRenderer;
    private Map3DFocusItem selectableItem;
    private SimulationObjectModel _itemSimObject;
    private bool _overridenByParentCB;
    private MapItemHierarchy _mapHierarchy;
    private string _representedObjName;
    private Map3DFocusItem _overrideMapItem;
    private bool _maneuverGizmoMoving;

    public int Priority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(Map3DFocusItem item, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConfigureColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetColor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMouseClickDelays() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverGizmoStateChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DFocusItemInteractable() => throw null;
  }
}
