﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.AppBarButton_Data
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
