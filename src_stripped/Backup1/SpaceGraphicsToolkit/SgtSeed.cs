// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtSeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
