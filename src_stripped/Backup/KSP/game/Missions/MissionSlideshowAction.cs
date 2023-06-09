﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionSlideshowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
