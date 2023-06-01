// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SpriteEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [FormerlySerializedAs("scale")]
    [SerializeField]
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
