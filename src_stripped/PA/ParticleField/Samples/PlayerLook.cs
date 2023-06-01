// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.PlayerLook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace PA.ParticleField.Samples
{
  public class PlayerLook : MonoBehaviour
  {
    public PlayerLook.RotationAxes axes;
    public float sensitivityX;
    public float sensitivityY;
    public float minimumX;
    public float maximumX;
    public float minimumY;
    public float maximumY;
    private float rotationY;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayerLook() => throw null;

    public enum RotationAxes
    {
      MouseXAndY,
      MouseX,
      MouseY,
    }
  }
}
