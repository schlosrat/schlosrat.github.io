// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.BaseNoiseGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VolumeCloud
{
  public abstract class BaseNoiseGenerator : INoiseGenerator
  {
    public int period;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract float Noise(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected BaseNoiseGenerator() => throw null;
  }
}
