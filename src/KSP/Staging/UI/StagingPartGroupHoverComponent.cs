// Decompiled with JetBrains decompiler
// Type: KSP.Staging.UI.StagingPartGroupHoverComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Staging.UI
{
  public class StagingPartGroupHoverComponent : 
    UIValueBinder<bool>,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    [SerializeField]
    private string _stageIndexPropertyKey;
    [SerializeField]
    private string _stageIndexPartWithinFolderPropertyKey;
    [SerializeField]
    private string _folderIndexPropertyKey;
    [SerializeField]
    private string _partFolderIndexPropertyKey;
    [SerializeField]
    private string _partGroupIndexPropertyKey;
    [SerializeField]
    private string _highlightPartGroupActionKey;
    private CanvasGroup _canvasGroup;
    private Image[] _image;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsCanvasGroupInteractable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetImagesRaycastTarget(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingPartGroupHoverComponent() => throw null;
  }
}
