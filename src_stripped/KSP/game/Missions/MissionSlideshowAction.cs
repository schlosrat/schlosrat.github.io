// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionSlideshowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  public class MissionSlideshowAction : MissionIndicatorAction
  {
    [JsonProperty]
    public Slides Slides;
    [JsonProperty]
    public float FinishButtonDelay;
    [JsonProperty]
    public System.Type OnDismissEventKey;
    [JsonIgnore]
    public Slideshow SpawnedSlideshow;
    [JsonIgnore]
    public int CurrentPressedButton;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PrefabLoadedSuccesfully(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IMissionAction DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionSlideshowAction() => throw null;
  }
}
