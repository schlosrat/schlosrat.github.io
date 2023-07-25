// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXParameterizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
