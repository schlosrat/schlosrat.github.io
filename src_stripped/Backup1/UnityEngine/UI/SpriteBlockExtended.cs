// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SpriteBlockExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [Serializable]
  public struct SpriteBlockExtended : IEquatable<SpriteState>, IEquatable<SpriteBlockExtended>
  {
    [SerializeField]
    [HideInInspector]
    private Sprite m_NormalSprite;
    [SerializeField]
    [HideInInspector]
    private SpriteState m_SpriteStates;

    public Sprite normalSprite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Sprite highlightedSprite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Sprite pressedSprite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Sprite disabledSprite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Sprite selectedSprite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(SpriteState other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(SpriteBlockExtended other) => throw null;
  }
}
