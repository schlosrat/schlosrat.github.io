// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RKData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
