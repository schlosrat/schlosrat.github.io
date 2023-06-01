// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCBuildingTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
