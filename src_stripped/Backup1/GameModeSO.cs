// Decompiled with JetBrains decompiler
// Type: GameModeSO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Contexts.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "gamemode.asset", menuName = "KSP/Game Mode")]
public class GameModeSO : ScriptableObject
{
  public GameModeData data;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GameModeSO() => throw null;
}
