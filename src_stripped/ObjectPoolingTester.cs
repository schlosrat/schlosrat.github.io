// Decompiled with JetBrains decompiler
// Type: ObjectPoolingTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
