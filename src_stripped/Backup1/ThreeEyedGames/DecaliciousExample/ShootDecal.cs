// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.DecaliciousExample.ShootDecal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ThreeEyedGames.DecaliciousExample
{
  public class ShootDecal : MonoBehaviour
  {
    public GameObject DecalPrefab;
    public float RemoveAfterSeconds;
    public float RoundsPerMin;
    public int TotalAmmo;
    public AudioClip Sound;
    protected float _timeSinceLastShot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IEnumerator RemoveDecal(GameObject decal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShootDecal() => throw null;
  }
}
