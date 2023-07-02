// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXContextVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
