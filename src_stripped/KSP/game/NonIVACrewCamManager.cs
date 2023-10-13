// Decompiled with JetBrains decompiler
// Type: KSP.Game.NonIVACrewCamManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class NonIVACrewCamManager
  {
    private const string SEAT_PREFAB_KEY = "shared_interior_seat_command.prefab";
    private const string PROBE_PREFAB_KEY = "shared_interior_probes.prefab";
    private const string MANAGER_OBJECT_NAME = "NonIVACrewCamManager";
    private const float PORTRAIT_ASSET_OFFSET = 1f;
    private const int MAX_PORTRAIT_ASSETS_PER_ROW = 10;
    private GameObject _managerObject;
    private Vector3 _initialPosition;
    private GameObject _seatPrefab;
    private GameObject _probePrefab;
    private List<GameObject> _portraitAssetObjectMasterList;
    private List<NonIVASeat> _unusedSeats;
    private DictionaryValueList<IGGuid, NonIVASeat[]> _usedSeatsMatrix;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera MakeProbeCamForPart(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Kerbal3DModel[] MakeCrewCamsForPart(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCrewCamsForPart(IGGuid partId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetPortraitAssetOffset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonIVACrewCamManager() => throw null;
  }
}
