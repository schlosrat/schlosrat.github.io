// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ModuleResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
