// Decompiled with JetBrains decompiler
// Type: KSP.UI.ActionBarButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (UIValue_ReadEnum_SetInteractible))]
  [RequireComponent(typeof (UIValue_ReadEnum_GraphicSet))]
  [RequireComponent(typeof (UIAction_Void_Button))]
  [RequireComponent(typeof (UIValue_ReadBool_SetActive))]
  public class ActionBarButton : MonoBehaviour
  {
    private const string FLIGHTHUD_TOOLTIP_PREFIX = "HUD/Tooltips/";
    public Image ButtonImage;
    public BasicTextTooltipData TooltipData;
    public ButtonExtendedVisualizer ButtonEventsVisualizer;
    private string _valueKey;
    private string _actionKey;
    private string _visibilityKey;
    private IDataContextReadonly _context;
    private UIAction_Void_Button _UIButton;
    private UIValue_ReadEnum_GraphicSet _UIEnumGraphic;
    private UIValue_ReadEnum_SetInteractible _UIEnumInteract;
    private UIValue_ReadBool_SetActive _UIEnabledSet;

    public string AppKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string ValueKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string ActionKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string VisibilityKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ActionBarButton_Data newButton, IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Rebind(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionBarButton() => throw null;
  }
}
