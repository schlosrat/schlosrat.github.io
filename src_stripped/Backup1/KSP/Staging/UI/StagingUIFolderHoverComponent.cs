// Decompiled with JetBrains decompiler
// Type: KSP.Staging.UI.StagingUIFolderHoverComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Staging.UI
{
  public class StagingUIFolderHoverComponent : 
    UIValueBinder<bool>,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    [SerializeField]
    private string _hoveredFolderIndexPropertyKey;
    [SerializeField]
    private string _selectedStageIndexPropertyKey;
    [SerializeField]
    private string _hoveredFolderActionKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetHoveredFolderIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingUIFolderHoverComponent() => throw null;
  }
}
