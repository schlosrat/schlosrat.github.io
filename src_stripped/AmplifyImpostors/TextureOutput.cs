// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.TextureOutput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyImpostors
{
  [Serializable]
  public class TextureOutput
  {
    [SerializeField]
    public int Index;
    [SerializeField]
    public OverrideMask OverrideMask;
    public bool Active;
    public string Name;
    public TextureScale Scale;
    public bool SRGB;
    public TextureChannels Channels;
    public TextureCompression Compression;
    public ImageFormat ImageFormat;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureOutput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureOutput(
      bool a,
      string n,
      TextureScale s,
      bool sr,
      TextureChannels c,
      TextureCompression nc,
      ImageFormat i)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureOutput Clone() => throw null;
  }
}
