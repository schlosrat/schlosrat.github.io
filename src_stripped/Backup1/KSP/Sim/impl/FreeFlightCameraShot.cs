// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FreeFlightCameraShot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class FreeFlightCameraShot : ICameraShot
  {
    private const double DEFAULT_FOV = 60.0;
    private const double DEFAULT_ORTHO_SIZE = 5.0;
    private const bool DEFAULT_ORTHOGRAPHIC = false;
    private double _fov;
    private double _orthoSize;
    private bool _isOrthographic;
    private TransformModel _parentTransform;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FreeFlightCameraShot(TransformModel parent) => throw null;

    public Position CameraPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation CameraRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector CameraForward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector CameraUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsOrthographic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double FieldOfView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double OrthographicSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
