// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.NavigationExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Navigation
{
  public static class NavigationExtension
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains<T>(this T[] array, T element) where T : class => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Positive(this float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectableElementInfo FindElementByDirection(
      this SelectableElementInfo baseInfo,
      in MoveDirection dir,
      in List<SelectableElementInfo> elements,
      NavigationParameter parameters)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectableElementInfo FindElementByDirection(
      this Vector2 point,
      MoveDirection direction,
      in List<SelectableElementInfo> elements,
      NavigationParameter parameters)
    {
      throw null;
    }
  }
}
