// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCBuildingTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class KSCBuildingTooltipData : KerbalMonoBehaviour
  {
    public string Name;
    public Sprite Icon;
    public string Desc;
    public KSCBuildingTooltipTarget KSCBuildingTooltipTarget;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCBuildingTooltipData() => throw null;
  }
}
