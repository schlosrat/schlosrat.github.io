// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TransitionVisualToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
