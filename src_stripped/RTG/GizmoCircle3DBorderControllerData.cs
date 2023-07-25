// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCircle3DBorderControllerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoCircle3DBorderControllerData
  {
    public Gizmo Gizmo;
    public GizmoPlaneSlider3D PlaneSlider;
    public GizmoCircle3DBorder Border;
    public GizmoHandle TargetHandle;
    public CircleShape3D TargetCircle;
    public CircleShape3D BorderCircle;
    public TorusShape3D BorderTorus;
    public CylTorusShape3D BorderCylTorus;
    public int BorderCircleIndex;
    public int BorderTorusIndex;
    public int BorderCylTorusIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCircle3DBorderControllerData() => throw null;
  }
}
