// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ManipulationCameraTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ManipulationCameraTest : MonoBehaviour
  {
    private bool isRotating;
    private bool isDragging;
    private Vector3 curPos;
    private Vector3 lastPos;
    public float speedMult;
    public float rotateSpeed;
    private GameObject grabbedObject;
    private GameObject cameraPivot;
    private Camera curCamera;
    private Plane dragPlane;
    private ManipulationWidget manipulationWidget;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManipulationCameraTest() => throw null;
  }
}
