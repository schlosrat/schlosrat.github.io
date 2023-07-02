// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXSurfacePair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [Serializable]
  public class VFXSurfacePair
  {
    [HideInInspector]
    public string Name;
    public VFXSurfaceType SurfaceType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXSurfacePair() => throw null;
  }
}
