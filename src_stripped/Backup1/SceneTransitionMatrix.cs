// Decompiled with JetBrains decompiler
// Type: SceneTransitionMatrix
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

[Serializable]
public class SceneTransitionMatrix
{
  public SceneTransitionMatrix.SceneTransitions[] From;

  public SceneTransitionMatrix.SceneTransitions this[GameScenes scn]
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetTransitionValue(GameScenes from, GameScenes to) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SceneTransitionMatrix() => throw null;

  [Serializable]
  public class SceneTransitions
  {
    public bool[] To;

    public bool this[GameScenes scn]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneTransitions() => throw null;
  }
}
