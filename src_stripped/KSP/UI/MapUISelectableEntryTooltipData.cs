// Decompiled with JetBrains decompiler
// Type: KSP.UI.MapUISelectableEntryTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
