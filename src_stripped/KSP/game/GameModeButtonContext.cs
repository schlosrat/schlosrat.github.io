// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameModeButtonContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class GameModeButtonContext : ApiDataContext
  {
    private string _id;
    private Action _setMode;
    [DataProperty("modeIcon")]
    public Property<Sprite> ModeIcon;
    [DataProperty("modeTitle")]
    public Property<string> ModeTitle;
    [DataProperty("modeDescription")]
    public Property<string> ModeDescription;
    [DataProperty("isCurrentMode")]
    public Property<bool> IsCurrentMode;

    public string Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [DataAction("setMode")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameModeButtonContext(
      string id,
      Action setModeAction,
      Sprite modeIcon,
      string modeTitle,
      string modeDescription,
      bool isCurrentMode)
    {
      throw null;
    }
  }
}
