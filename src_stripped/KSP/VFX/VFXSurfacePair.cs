// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXSurfacePair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
