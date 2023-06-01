// Decompiled with JetBrains decompiler
// Type: KSP.UI.AppBarButton_Data
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [Serializable]
  public class AppBarButton_Data
  {
    public string appKey;
    public Sprite ButtonImage;
    public string ValueKey;
    public string InteractibleKey;
    public string TooltipString;
    public string IndicatorTagName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AppBarButton_Data() => throw null;
  }
}
