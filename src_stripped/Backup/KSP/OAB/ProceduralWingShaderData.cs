// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralWingShaderData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ProceduralWingShaderData : KerbalMonoBehaviour
  {
    [Header("Visible Meshes")]
    [SerializeField]
    private SkinnedMeshRenderer flap;
    [SerializeField]
    private SkinnedMeshRenderer flapGuard;
    [SerializeField]
    private SkinnedMeshRenderer leading;
    [SerializeField]
    private SkinnedMeshRenderer leadingConnection;
    [SerializeField]
    private SkinnedMeshRenderer main;
    [SerializeField]
    private SkinnedMeshRenderer mainConnection;
    [SerializeField]
    private SkinnedMeshRenderer trailing;
    [SerializeField]
    private SkinnedMeshRenderer trailingConnection;
    private bool hasFlap;
    private bool hasFlapGuard;
    private bool hasLeading;
    private bool hasLeadingConnection;
    private bool hasMain;
    private bool hasMainConnection;
    private bool hasTrailing;
    private bool hasTrailingConnection;
    [SerializeField]
    [Header("Bones for Anchor")]
    private Transform rotLeadingL;
    [SerializeField]
    private Transform rotLeadingR;
    [SerializeField]
    private Transform rotControlL;
    [SerializeField]
    private Transform rotControlR;
    [Header("Projection Matrices")]
    [SerializeField]
    private Transform projWingFront;
    [SerializeField]
    private Transform projWingBack;
    [SerializeField]
    private Transform projWingTop;
    [SerializeField]
    private Transform projWingBottom;
    [SerializeField]
    private Transform projWingTip;
    [SerializeField]
    private Transform projWingRoot;
    private ProjectionTransformConstraint projConFront;
    private ProjectionTransformConstraint projConBack;
    private ProjectionTransformConstraint projConTop;
    private ProjectionTransformConstraint projConBottom;
    private ProjectionTransformConstraint projConTip;
    private ProjectionTransformConstraint projConRoot;
    private int projMatrixX_ID;
    private int projMatrixY_ID;
    private int projMatrixZ_ID;
    private int projRotX_ID;
    private int projRotY_ID;
    private int projRotZ_ID;
    private GameObject currentTarget;
    private OffsetSliderSystem targetSliderSystem;
    private float frontRot;
    private float backRot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEventLinks(bool turnOnEvents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTargets(GameObject target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateProjectionConstraints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CacheObjNulls() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeShaderValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralWingShaderData() => throw null;
  }
}
