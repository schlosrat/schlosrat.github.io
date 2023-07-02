// Decompiled with JetBrains decompiler
// Type: LibNoise.Modifiers.RotateInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace LibNoise.Modifiers
{
  public class RotateInput : IModule
  {
    private double XAngle;
    private double YAngle;
    private double ZAngle;
    private double m_x1Matrix;
    private double m_x2Matrix;
    private double m_x3Matrix;
    private double m_y1Matrix;
    private double m_y2Matrix;
    private double m_y3Matrix;
    private double m_z1Matrix;
    private double m_z2Matrix;
    private double m_z3Matrix;

    public IModule SourceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotateInput(IModule sourceModule, double xAngle, double yAngle, double zAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAngles(double xAngle, double yAngle, double zAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3d coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3 coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(double x, double y, double z) => throw null;
  }
}
