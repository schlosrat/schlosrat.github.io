// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXParameterizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  public abstract class VFXParameterizer : KerbalMonoBehaviour
  {
    public List<VFXParameterMapping> ParameterMappingsList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void UpdateFromContextData(
      FXContextData contextData,
      FXPartContextData partData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected VFXParameterizer() => throw null;
  }
}
