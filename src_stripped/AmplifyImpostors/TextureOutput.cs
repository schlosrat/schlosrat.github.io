// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.TextureOutput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
