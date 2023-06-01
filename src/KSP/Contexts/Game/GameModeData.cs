// Decompiled with JetBrains decompiler
// Type: KSP.Contexts.Game.GameModeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Contexts.Game
{
  [Serializable]
  public struct GameModeData
  {
    public string DefaultSaveKey;
    public string Name;
    public string Description;
    [Tooltip("THE GAME MODE, used internally by this enum name. Ensure that the enum option shows up for the Game mode wanted.")]
    public CampaignMode campaignMode;
    [Tooltip("Set the loc key here")]
    public string displayName;
    [Tooltip("Set the loc key here")]
    public string displayDescription;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameModeData Defaults() => throw null;
  }
}
