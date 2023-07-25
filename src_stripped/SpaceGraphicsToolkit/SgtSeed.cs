// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtSeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace SpaceGraphicsToolkit
{
  [Serializable]
  public struct SgtSeed
  {
    public int Value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtSeed(int newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator int(SgtSeed seed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator SgtSeed(int newValue) => throw null;
  }
}
