// Decompiled with JetBrains decompiler
// Type: AtlasSplitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
