// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.MouseOverEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class MouseOverEventHandler : 
    UIBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    public UnityEvent onMouseEnter;
    public UnityEvent onMouseExit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MouseOverEventHandler() => throw null;
  }
}
