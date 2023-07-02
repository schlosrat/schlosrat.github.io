// Decompiled with JetBrains decompiler
// Type: KSP.UI.MapUISelectableEntryTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class MapUISelectableEntryTooltipData : KerbalMonoBehaviour
  {
    [Tooltip("Use the localization key for the primary line here, the path for adding new loc keys is: 'Menu/TrackingStation/Tooltips/--Inset Key Here--")]
    public string PrimaryLineKey;
    [Tooltip("Use the localization key for the secondary line here, the path for adding new loc keys is: 'Menu/TrackingStation/Tooltips/--Inset Key Here--")]
    public string SecondaryLineKey;
    public MapUISelectableEntryTooltipTarget MapUISelectableEntryTooltipTargetObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapUISelectableEntryTooltipData() => throw null;
  }
}
