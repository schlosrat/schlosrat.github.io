// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RKData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class RKData
  {
    public double[,] A;
    public double[] B;
    public double[] C;
    public double[] E;
    public int ERROR_ESTIMATOR_ORDER;
    public int N_STAGES;
    public int ORDER;
    public double[,] P;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RKData() => throw null;
  }
}
