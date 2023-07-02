// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Data.CenterOfPhysicalProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
