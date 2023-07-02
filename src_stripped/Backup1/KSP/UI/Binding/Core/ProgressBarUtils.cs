// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.ProgressBarUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
