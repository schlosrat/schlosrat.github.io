// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ModuleResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class ModuleResource
  {
    public string name;
    public string title;
    public int id;
    public double amount;
    public double rate;
    public double currentRequest;
    public double currentAmount;
    public bool varyTime;
    public bool useSI;
    public double displayUnitMult;
    public string unitName;
    public bool available;
    public bool isDeprived;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleResource() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDeprived(float requestThreshold = 0.9f) => throw null;
  }
}
