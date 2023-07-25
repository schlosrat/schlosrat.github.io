// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ModuleResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
