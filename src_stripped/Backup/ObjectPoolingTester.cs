﻿// Decompiled with JetBrains decompiler
// Type: ObjectPoolingTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
