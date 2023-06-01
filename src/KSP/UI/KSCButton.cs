// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (Selectable))]
  public class KSCButton : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler,
    IPointerClickHandler
  {
    private const float VIEWPORT_LEFT_SIDE = 0.0f;
    private const float VIEWPORT_RIGHT_SIDE = 1f;
    private const float VIEWPORT_TOP_SIDE = 0.0f;
    private const float VIEWPORT_BOTTOM_SIDE = 1f;
    private const float VIEWPORT_BEHIND = 0.0f;
    [SerializeField]
    private KSCNavEnum _buildingEnum;
    [SerializeField]
    private KSCButtonTooltip _buttonTooltipPrefab;
    [SerializeField]
    private Vector2 _buttonTooltipOffset;
    private KSCTargetableBuilding _attachedBuilding;
    private KSCBuildingTooltipTarget _tooltipTarget;
    private Selectable _selectable;
    private KSCButtonTooltip _currentButtonTooltip;

    public KSCNavEnum BuildingEnum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSCTargetableBuilding AttachedBuilding
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KSCBuildingTooltipTarget AttachedBuildingTooltipTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Selectable Selectable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HighlightButton(bool isHighlighted, PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableUISpaceTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCButton() => throw null;
  }
}
