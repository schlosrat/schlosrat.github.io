// Decompiled with JetBrains decompiler
// Type: NavigateItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class NavigateItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
  public int ItemIndex;

  public event Action<int> PointerEnter
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerEnter(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NavigateItem() => throw null;
}
