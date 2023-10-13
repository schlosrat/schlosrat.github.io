// Decompiled with JetBrains decompiler
// Type: KSP.UI.PartInfoContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class PartInfoContext : ApiDataContext
  {
    [DataProperty("IsVisible")]
    public Property<bool> IsVisible;
    [DataProperty("PartInfoManufacturer")]
    public Property<string> PartInfoManufacturer;
    [DataProperty("PartInfoSizeText")]
    public Property<string> PartInfoSizeText;
    [DataProperty("PartInfoSizeColor")]
    public Property<Color> PartInfoSizeColor;
    [DataProperty("PartInfoName")]
    public Property<string> PartInfoName;
    [DataProperty("PartInfoIsFavorite")]
    public Property<bool> PartInfoIsFavorite;
    [DataProperty("PartInfoSubtitle")]
    public Property<string> PartInfoSubtitle;
    [DataProperty("PartInfoDescription")]
    public Property<string> PartInfoDescription;
    [DataProperty("PartInfoLineList")]
    public ContextListProperty<PartInfoLineContext> PartInfoLineList;
    [DataProperty("PartInfoAreControlsVisible")]
    public Property<bool> PartInfoAreControlsVisible;
    [DataProperty("PartInfoCanShowMore")]
    public Property<bool> PartInfoCanShowMore;
    [DataProperty("PartInfoToggleExpandText")]
    public Property<string> PartInfoToggleExpandText;
    [DataProperty("PartInfoIsShowingMore")]
    public Property<bool> PartInfoIsShowingMore;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoContext() => throw null;
  }
}
