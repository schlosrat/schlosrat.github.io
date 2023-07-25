// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TransitionVisualToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Inspector;
using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [Serializable]
  public struct TransitionVisualToggle
  {
    [DisableArrayPagination]
    public Graphic[] targetGraphics;
    public TransitionVisualData transitionDataOn;
    public TransitionVisualData transitionDataOff;

    public static TransitionVisualToggle Default
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
