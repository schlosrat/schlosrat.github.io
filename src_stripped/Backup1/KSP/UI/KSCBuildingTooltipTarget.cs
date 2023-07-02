// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCBuildingTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class KSCBuildingTooltipTarget : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    [SerializeField]
    private KSCBuildingTooltip _tooltipPrefab;
    public Vector2 TooltipOffset;
    [SerializeField]
    private bool _isActive;
    [Header("If left blank, the target will apply to this gameObject")]
    [SerializeField]
    private GameObject _gameObjectToTarget;
    private KSCBuildingTooltip _currentTooltip;
    private KSCBuildingTooltipData _tooltipData;
    private SubscriptionHandle _handleGameStateLeft;

    public int Priority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSCBuildingTooltip CurrentTooltip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KSCBuildingTooltipData TooltipData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject GameObjectToTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize(string name, string description, Sprite icon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateLeft(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCBuildingTooltipTarget() => throw null;
  }
}
