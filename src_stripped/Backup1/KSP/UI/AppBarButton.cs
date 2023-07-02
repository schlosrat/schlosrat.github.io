// Decompiled with JetBrains decompiler
// Type: KSP.UI.AppBarButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (UIValue_WriteBool_Toggle))]
  [RequireComponent(typeof (UIValue_ReadBool_SetInteractable))]
  public class AppBarButton : MonoBehaviour
  {
    private const string FLIGHTHUD_TOOLTIP_PREFIX = "HUD/Tooltips/";
    public Image ButtonImage;
    private string _valueKey;
    private string _interactibleKey;
    private IDataContextReadonly _context;
    private UIValue_WriteBool_Toggle _UIBoolValue;
    private UIValue_ReadBool_SetInteractable _UIBoolInteract;
    private BasicTextTooltipData _tooltipData;

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

    public string InteractibleKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(AppBarButton_Data newButton, IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Rebind(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AppBarButton() => throw null;
  }
}
