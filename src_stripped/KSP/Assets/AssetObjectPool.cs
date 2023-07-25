// Decompiled with JetBrains decompiler
// Type: KSP.Assets.AssetObjectPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Assets
{
  public class AssetObjectPool : MonoBehaviour
  {
    [SerializeField]
    private List<PooledKerbalMonoBehaviour> _pooledObjects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetObject(out GameObject result, Transform parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(PooledKerbalMonoBehaviour pkmb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pool(PooledKerbalMonoBehaviour pkmb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssetObjectPool() => throw null;
  }
}
