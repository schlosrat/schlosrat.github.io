// Decompiled with JetBrains decompiler
// Type: SetAgencyFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SetAgencyFlag : KerbalMonoBehaviour
{
  [SerializeField]
  private string _flagDiffuseTextureShaderName;
  [SerializeField]
  private string _flagPaintMaskShaderName;
  [SerializeField]
  private string _teamColorAccentShaderName;
  [SerializeField]
  private string _teamColorBaseShaderName;
  [SerializeField]
  private int _teamColorAccentShaderID;
  [SerializeField]
  private int _teamColorBaseShaderID;
  [SerializeField]
  private Renderer[] _meshesWithMaterialsToUpdate;
  private bool _initialized;
  private List<Material> _managedMaterials;
  private Texture2D _agencyDiffuseTexture;
  private Texture2D _agencyPaintMaskTexture;
  private AgencyUtils.TeamColorSet _teamColors;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnAgencyFlagDoneLoading(AgencyEntry agencyEntry, bool success) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateMaterials() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetAgencyData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SetAgencyFlag() => throw null;
}
