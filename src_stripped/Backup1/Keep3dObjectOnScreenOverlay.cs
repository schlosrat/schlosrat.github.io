// Decompiled with JetBrains decompiler
// Type: Keep3dObjectOnScreenOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class Keep3dObjectOnScreenOverlay : MonoBehaviour
{
  [Tooltip("Pick the RectTransform in the UI where you want your 3d object to stay")]
  public RectTransform overlayTransformToMoveTo;
  [Tooltip("Pick the Transform of the 3D object you want to stay with the rest of the UI")]
  public Transform goToReposition;
  [Tooltip("How far away from the camera do you need it to sit?")]
  public float zOffset;
  [Tooltip("The Camera that has the UI overlayed on it. If left empty, will default to the MainCamera")]
  public Camera cameraBeingOverlayed;
  private Vector3 currentPosition;
  private Quaternion currentOrientation;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CalcWorldPosRot() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Keep3dObjectOnScreenOverlay() => throw null;
}
