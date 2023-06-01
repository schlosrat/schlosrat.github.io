// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuQuicksaveIconController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using ControlIcons;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class ESCMenuQuicksaveIconController : KerbalMonoBehaviour
  {
    [SerializeField]
    private ControlIconsAssets controlIconsAssetsPS;
    [SerializeField]
    private ControlIconsAssets controlIconsAssetsXbox;
    [SerializeField]
    private PCIcons controlIconsPC;
    private ControlIconsAssets _controlIconsConsole;
    [SerializeField]
    private Image quicksaveIcon;
    [SerializeField]
    private Image loadQuicksaveIcon;
    private RectTransform[] _childRectTransforms;
    private bool _canSaveOrLoad;
    private bool _bHideOnPC;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeIconsByInPut(bool isPC) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetIcons(bool isPC) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlatformChanged(bool isPC) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetActionActive(bool isPC) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideOnPC(bool isPC) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCanSaveOrLoad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuQuicksaveIconController() => throw null;
  }
}
