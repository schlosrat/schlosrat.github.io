// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.SpriteEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
    [SerializeField]
    [FormerlySerializedAs("label")]
    private string m_label;
    [SerializeField]
    [FormerlySerializedAs("color")]
    private Color m_color;
    [SerializeField]
    [FormerlySerializedAs("scale")]
    private float m_scale;
    [SerializeField]
    [FormerlySerializedAs("sprite")]
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
