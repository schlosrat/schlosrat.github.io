// Decompiled with JetBrains decompiler
// Type: KSP.DropdownBlockerButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP
{
  public class DropdownBlockerButton : Button
  {
    public Action<PointerEventData> onPointerClick;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DropdownBlockerButton() => throw null;
  }
}
