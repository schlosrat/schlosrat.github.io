// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCBuildingTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
