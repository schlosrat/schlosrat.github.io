// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  [Serializable]
  public class VFXParameter
  {
    public string Id;
    public string DisplayName;
    public VFXContextVariableType MappingType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXParameter(string id, string displayName, VFXContextVariableType mappingType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(VFXParameter p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;
  }
}
