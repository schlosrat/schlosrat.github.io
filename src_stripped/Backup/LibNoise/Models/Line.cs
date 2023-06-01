// Decompiled with JetBrains decompiler
// Type: LibNoise.Models.Line
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace LibNoise.Models
{
  public class Line
  {
    private double m_x0;
    private double m_x1;
    private double m_y0;
    private double m_y1;
    private double m_z0;
    private double m_z1;

    public IModule SourceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Attenuate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Line(IModule sourceModule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(double p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStartPoint(double x, double y, double z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEndPoint(double x, double y, double z) => throw null;
  }
}
