// Decompiled with JetBrains decompiler
// Type: KSP.UI.KerbalManagerSlotContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class KerbalManagerSlotContext : ApiDataContext
  {
    [DataProperty("name")]
    public Property<string> Name;
    [DataProperty("icon")]
    public Property<Sprite> Icon;
    [DataProperty("kerbalId")]
    public Property<IGGuid> KerbalId;
    [DataProperty("locationID")]
    public Property<IGGuid> LocationId;
    [DataProperty("isRightSide")]
    public Property<bool> IsRightSide;
    [DataProperty("hasIcon")]
    public Property<bool> HasIcon;
    [DataProperty("isDragging")]
    public Property<bool> IsDragging;
    [DataProperty("isHighlighted")]
    public Property<bool> IsHighlighted;
    [DataProperty("isHighlightedEmpty")]
    public Property<bool> IsHighlightedEmpty;
    [DataProperty("isValidDrop")]
    public Property<bool> IsValidDrop;
    [DataProperty("isValidDropEmpty")]
    public Property<bool> IsValidDropEmpty;
    [DataProperty("isEmpty")]
    public Property<bool> IsEmpty;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalManagerSlotContext(
      string name,
      Sprite icon,
      IGGuid kerbalId,
      IGGuid locationId,
      bool isRightSide,
      bool isEmpty)
    {
      throw null;
    }
  }
}
