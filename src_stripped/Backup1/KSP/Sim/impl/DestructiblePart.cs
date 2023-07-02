// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.DestructiblePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class DestructiblePart : MonoBehaviour
  {
    [SerializeField]
    private Mesh swapMesh;
    [SerializeField]
    private Material swapMaterial;
    private GameObject part;
    private Vector3 startScale;
    private PartOwnerBehavior partOwner;
    private float startTime;
    private bool scaleDown;
    private Action callback;
    public float destroyTime;
    public float scaleFactor;
    private float scaleAmount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPart(PartOwnerBehavior partOwner, GameObject part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwapMaterial(GameObject part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SwapMesh(GameObject part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartScaleDown(Action callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DestructiblePart() => throw null;
  }
}
