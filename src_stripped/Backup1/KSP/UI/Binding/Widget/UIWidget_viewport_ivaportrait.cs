// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_viewport_ivaportrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Header("Camera View Texture - Readable")]
    [SerializeField]
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
