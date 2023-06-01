// Decompiled with JetBrains decompiler
// Type: PredefinedSimObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisableCustomEditorBase]
[CreateAssetMenu(fileName = "PredefinedSimObject", menuName = "ScriptableObjects/PredefinedSimObject")]
[Serializable]
public class PredefinedSimObject : ScriptableObject
{
  public string Name;
  public string RelativeToName;
  public TransformFrameType ReferenceFrame;
  [HideInInspector]
  [SerializeField]
  public PredefinedSimObject.Vector3DStore LocalPosition;
  [HideInInspector]
  [SerializeField]
  public PredefinedSimObject.QuaternionDStore LocalRotation;
  public bool FixedGuid;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PredefinedSimObject() => throw null;

  [Serializable]
  public class Vector3DStore
  {
    public string x;
    public string y;
    public string z;

    public Vector3d AsVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStrings(Vector3d vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3DStore() => throw null;
  }

  [Serializable]
  public class QuaternionDStore : PredefinedSimObject.Vector3DStore
  {
    public string w;

    public QuaternionD AsQuaternion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStrings(QuaternionD quaternion) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionDStore() => throw null;
  }
}
