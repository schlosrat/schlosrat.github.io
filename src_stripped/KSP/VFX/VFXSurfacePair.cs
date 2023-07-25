// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXSurfacePair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
