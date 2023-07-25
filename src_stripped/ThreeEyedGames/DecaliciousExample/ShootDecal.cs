// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.DecaliciousExample.ShootDecal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
