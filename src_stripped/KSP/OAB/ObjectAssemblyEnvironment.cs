// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyEnvironment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyEnvironment : MonoBehaviour, IObjectAssemblyEnvironment
  {
    [Tooltip("The OAB Camera is kept within the area specified by this object. This CAN be null.")]
    [SerializeField]
    private GameObject buildAreaBounds;
    [Tooltip("Objects associated with this specific environment that get shown or hidden. Note that this root object isn't supposed to be shown/hidden.")]
    [SerializeField]
    private List<GameObject> environmentObjects;
    [SerializeField]
    [TextArea(3, 20)]
    private string _notes;
    [SerializeField]
    private OABEnvironmentType environmentType;
    [SerializeField]
    private Transform environmentCenter;
    [Tooltip("Height size limit in meters for environment used in VAB")]
    [SerializeField]
    private float maxVABHeight;
    [Tooltip("Width size limit in meters for environment used in VAB")]
    [SerializeField]
    private float maxVABWidth;
    [SerializeField]
    [Tooltip("Depth size limit in meters for environment used in VAB")]
    private float maxVABDepth;
    [SerializeField]
    [Tooltip("BAE's maximum height size limit value in meters from the center of the cylinder (i.e. Environment Center)")]
    private float maxBAEHeight;
    [Tooltip("BAE's minimum height size limit value in meters from the center of the cylinder (i.e. Environment Center)")]
    [SerializeField]
    private float minBAEHeight;
    [Tooltip("Radius in meters for size limit cylinder used in BAE")]
    [SerializeField]
    private float maxBAERadius;
    [SerializeField]
    private List<CutsceneLocationLink> cutsceneLocations;
    [SerializeField]
    private List<GameObject> _objectsToHideInOrthoMode;

    public OABEnvironmentType EnvironmentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform EnvironmentCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<CutsceneLocationLink> CutsceneLocations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<GameObject> ObjectsToHideInOrthoMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideEnvironmentObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowEnvironmentObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Collider BuildAreaBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyBuilderSizeLimits BuildSizeLimits(OABVariant variant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyEnvironment() => throw null;
  }
}
