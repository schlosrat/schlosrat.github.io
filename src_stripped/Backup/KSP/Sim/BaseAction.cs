// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BaseAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
