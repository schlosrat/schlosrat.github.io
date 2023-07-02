// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SpriteEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
  [Serializable]
  public struct SpriteEntry
  {
    [FormerlySerializedAs("label")]
    [SerializeField]
    private string m_label;
    [FormerlySerializedAs("color")]
    [SerializeField]
    private Color m_color;
    [SerializeField]
    [FormerlySerializedAs("scale")]
    private float m_scale;
    [FormerlySerializedAs("sprite")]
    [SerializeField]
    private Sprite m_sprite;

    public static SpriteEntry Default
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string label
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float scale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Sprite sprite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }
  }
}
