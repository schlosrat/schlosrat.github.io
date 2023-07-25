// Decompiled with JetBrains decompiler
// Type: KSP.UI.ActionBarButton_Data
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
  public class ActionBarButton_Data
  {
    public string appKey;
    public Sprite ButtonImage;
    public string ValueKey;
    public string ActionKey;
    public string EnabledKey;
    public string TooltipString;
    public string IndicatorTagName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionBarButton_Data() => throw null;
  }
}
