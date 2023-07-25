// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.PlayerLook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
