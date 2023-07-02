// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilderTooltipDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilderTooltipDisplay : 
    KerbalMonoBehaviour,
    ISelectHandler,
    IEventSystemHandler,
    IDeselectHandler,
    IPointerEnterHandler,
    IPointerExitHandler
  {
    [SerializeField]
    private string tooltipText;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string TranslateText(string toTranslateKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilderTooltipDisplay() => throw null;
  }
}
