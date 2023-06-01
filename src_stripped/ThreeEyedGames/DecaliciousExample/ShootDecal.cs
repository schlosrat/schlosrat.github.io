// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.DecaliciousExample.ShootDecal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
