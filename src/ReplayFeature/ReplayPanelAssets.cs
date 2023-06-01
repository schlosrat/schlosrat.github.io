// Decompiled with JetBrains decompiler
// Type: ReplayFeature.ReplayPanelAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace ReplayFeature
{
  [CreateAssetMenu(fileName = "ReplayPanelIcons", menuName = "ScriptableObjects/ReplayPanelAssets")]
  public class ReplayPanelAssets : ScriptableObject
  {
    public Sprite Button_Backward;
    public Sprite Button_PlayGame;
    public Sprite Button_PauseGame;
    public Sprite Button_Forward;
    public Sprite Button_HideReplayUI;
    public Sprite Button_HideHUD;
    public Sprite Button_HideFilledHUD;
    public Sprite Button_PhotoMode;
    public Sprite Button_Record;
    public Sprite Button_SaveReplay;
    public Sprite Button_PlayFromHere;
    public Sprite Button_CinematicCamera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReplayPanelAssets() => throw null;
  }
}
