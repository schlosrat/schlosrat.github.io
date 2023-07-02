// Decompiled with JetBrains decompiler
// Type: AtlasSplitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AtlasSplitter : MonoBehaviour
{
  public AtlasSplitter.Atlas[] atlases;
  public string outputPath;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AtlasSplitter() => throw null;

  [Serializable]
  public class Atlas
  {
    public Texture2D[] tex;
    public int xCount;
    public int yCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Atlas() => throw null;
  }
}
