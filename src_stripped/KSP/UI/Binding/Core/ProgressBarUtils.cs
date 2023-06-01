// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.ProgressBarUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public static class ProgressBarUtils
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FillRectBar(
      RectTransform transform,
      ProgressBarUtils.ProgressBarDirection direction,
      float factor)
    {
      throw null;
    }

    public enum ProgressBarDirection
    {
      AnchorLeft,
      AnchorRight,
      AnchorTop,
      AnchorBottom,
      Horizontal,
      Vertical,
      Central,
    }
  }
}
