// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BaseAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class BaseAction
  {
    public string name;
    public string guiName;
    public bool active;
    public bool requireFullControl;
    public bool advancedTweakable;
    public bool isPersistent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseAction() => throw null;
  }
}
