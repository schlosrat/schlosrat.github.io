// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXContextVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  [Serializable]
  public class VFXContextVariable
  {
    public string Id;
    public string DisplayName;
    public VFXContextVariableType Type;
    public string Description;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXContextVariable(
      string id,
      string name,
      VFXContextVariableType type,
      string description)
    {
      throw null;
    }
  }
}
