// Decompiled with JetBrains decompiler
// Type: KSP.UI.Highlight_Data
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Map;
using KSP.OAB;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [Serializable]
  public class Highlight_Data
  {
    public HighlightType highlightType;
    public bool trackInNavball;
    public string attachNodeID;
    public Vector3 offset;
    public Vector3 orientation;
    public string highlightPrefabPath;
    [Tooltip("The registration id of the object or prefab being tracked in 3D., usually set on Mission Editor or other similar")]
    public string trackingObjectID;
    [Tooltip("IG GUID of the object we want to track from World Space")]
    public IGGuid trackingGUID;
    [Tooltip("Name of the celestial body we want to track from World Space")]
    public string celestialBodyName;
    public bool hasValidSimObjectTracking;
    public SimulationObjectModel simObjectTracking;
    public ObjectAssemblyPart highlightedOABPart;
    public bool cb_Coordinates;
    public Vector3d cb_Coords;
    public ManeuverGizmoInputType maneuverGizmoHandle;
    public Map3DTrajectoryEvents.EventType orbitNodeTrajectoryEvent;
    public double UToffset;
    public string poolKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Highlight_Data() => throw null;
  }
}
