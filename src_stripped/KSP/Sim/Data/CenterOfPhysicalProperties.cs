// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Data.CenterOfPhysicalProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.Data
{
  public class CenterOfPhysicalProperties
  {
    public Vector3d CoM;
    public Vector3d CoP;
    public Vector3d CoT;
    public Vector3d CoR;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CenterOfPhysicalProperties(
      Vector3d mass,
      Vector3d pressure,
      Vector3d thrust,
      Vector3d radiation)
    {
      throw null;
    }
  }
}
