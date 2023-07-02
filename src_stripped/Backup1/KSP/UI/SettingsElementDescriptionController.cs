// Decompiled with JetBrains decompiler
// Type: KSP.UI.SettingsElementDescriptionController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class SettingsElementDescriptionController : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    private const string DEFAULT_NORMAL_STRING = "Normal";
    private const string DEFAULT_HOVERED_STRING = "Hovered";
    private const string LOCALIZATION_KEYS_PATH = "Menu/Settings/Descriptions/";
    [SerializeField]
    private string _descriptionLocalizationKey;
    [SerializeField]
    [Header("Animations keys")]
    private string _onNormalAnimation;
    [SerializeField]
    private string _onHoverAnimation;
    private List<DOTweenAnimation> _tweenAnimations;
    private bool _isInputSettingElement;

    public string DescriptionLocalizationKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsInputSettingElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHover(bool isHovered) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SettingsElementDescriptionController() => throw null;
  }
}
