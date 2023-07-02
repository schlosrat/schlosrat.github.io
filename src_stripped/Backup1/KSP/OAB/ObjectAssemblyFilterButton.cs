// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyFilterButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyFilterButton : 
    UIStateVisualsBase,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler,
    IPointerDownHandler,
    IPointerUpHandler
  {
    [HideInInspector]
    public AssemblyPartsPicker partsPicker;
    [HideInInspector]
    public Button ButtonReference;
    public AssemblyPartFilterType filter;
    protected bool isSelected;
    private bool _reverseFilter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnButtonClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSelected(bool selected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyFilterButton() => throw null;
  }
}
