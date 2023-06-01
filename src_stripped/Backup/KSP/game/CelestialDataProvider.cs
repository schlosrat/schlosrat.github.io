// Decompiled with JetBrains decompiler
// Type: KSP.Game.CelestialDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class CelestialDataProvider : DataBus<CelestialBodyComponent>
  {
    private PropertyExternal<KSP.Sim.Position> position_Internal;
    private PropertyExternal<double> albedo_Internal;
    private PropertyExternal<double> atmosphereDepth_Internal;
    private PropertyExternal<CelestialDataProvider> referenceBody_Internal;
    private PropertyExternal<IEnumerable<CelestialDataProvider>> orbitingBodies_Internal;
    private PropertyExternal<CelestialDataProvider> getRelevantStar_Internal;

    public IProperty<double> Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IProperty<KSP.Sim.Position> Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<double> Albedo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<bool> HasAtmosphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IProperty<double> AtmosphereDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<CelestialDataProvider> ReferenceBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<IEnumerable<CelestialDataProvider>> OrbitingBodies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<CelestialDataProvider> GetRelevantStar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<bool> IsStar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialDataProvider(CelestialBodyComponent dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ValidateProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<CelestialDataProvider> GetOrbitingBodies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSP.Sim.Position GetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetAlbedo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetHasAtmosphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetAtmosphereDepth() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetIsStar() => throw null;
  }
}
