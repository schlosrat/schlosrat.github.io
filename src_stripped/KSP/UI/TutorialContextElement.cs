// Decompiled with JetBrains decompiler
// Type: KSP.UI.TutorialContextElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class TutorialContextElement : ApiDataContext
  {
    [DataProperty("title")]
    public PropertyReadonly<string> Title;
    [DataProperty("icon")]
    public PropertyReadonly<Sprite> Icon;
    [DataProperty("featureImage")]
    public PropertyReadonly<Sprite> FeatureImageIcon;
    [DataProperty("progress")]
    public PropertyReadonly<Sprite> ProgressIcon;
    [DataProperty("description")]
    public PropertyReadonly<string> Description;
    [DataProperty("percentage")]
    public PropertyReadonly<string> Percentage;
    public string Id;
    public string MissionId;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TutorialContextElement(
      string id,
      string title,
      string description,
      Sprite icon,
      Sprite featureImageIcon,
      string percentage,
      Sprite progressIcon = null,
      string missionID = "parent")
    {
      throw null;
    }
  }
}
