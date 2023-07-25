// Decompiled with JetBrains decompiler
// Type: ObjectPoolingTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectPoolingTester : KerbalMonoBehaviour
{
  [SerializeField]
  private TestPoolObject _objectPrefab;
  private IObjectPool<TestPoolObject> _testObjectPool;
  private Queue<TestPoolObject> _instances;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [ContextMenu("Get Instance")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GetInstance() => throw null;

  [ContextMenu("Release Last Instance")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ReleaseLastObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetInstance(TestPoolObject targetObject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ObjectPoolingTester() => throw null;
}
