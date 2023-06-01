// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Data.CenterOfPhysicalProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
