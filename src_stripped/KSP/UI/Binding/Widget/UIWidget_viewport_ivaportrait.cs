// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_viewport_ivaportrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_viewport_ivaportrait : UIWidget
  {
    [SerializeField]
    [Header("Name - Readable")]
    private UIValueBinder portraitName;
    [SerializeField]
    [Header("Camera View Texture - Readable")]
    private UIValueBinder cameraviewTexture;
    [SerializeField]
    private RawImage portrait;
    [SerializeField]
    private TextMeshProUGUI kerbalNamePlate;
    [SerializeField]
    private ButtonExtended buttonEVA;
    private BasicTextTooltipData _evaBasicTooltipData;
    private bool _isEVAButtonAvailable;

    public IUIValueBindable<string> PortraitName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueBindable<Texture> CameraviewTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsButtonEVAVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetKerbalName(string kerbalName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicTextTooltipData GetBasicTooltipDataForEVAButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RenderTexture GetPortraitTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPortraitTexture(RenderTexture targetRenderTexture) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPortraitTexture(Texture targetTexture) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEVAButtonAvailable(bool isEVAButtonAvailable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetButtonEVAInteractable(bool interactable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleMouseEnterForButtonEVA() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleMouseExitForButtonEVA() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterButtonEVAListener(UnityAction callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterAllButtonEVAListeners() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_viewport_ivaportrait() => throw null;
  }
}
