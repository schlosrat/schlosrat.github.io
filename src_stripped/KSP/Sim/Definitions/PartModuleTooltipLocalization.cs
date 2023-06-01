// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartModuleTooltipLocalization
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public static class PartModuleTooltipLocalization
  {
    public const string TOOLTIP_RESOURCE = "PartModules/Generic/Tooltip/Resource";
    public const string TOOLTIP_RESOURCES = "PartModules/Generic/Tooltip/Resources";
    public const string TOOLTIP_RESOURCE_RATE_MAX = "PartModules/Generic/Tooltip/ResourceRateMax";
    public const string TOOLTIP_RESOURCE_RATE = "PartModules/Generic/Tooltip/ResourceRate";
    public const string TOOLTIP_PROPELLANTS = "PartModules/Generic/Tooltip/Propellants";
    public const string TOOLTIP_INPUTS = "PartModules/Generic/Tooltip/Inputs";
    public const string TOOLTIP_OUTPUTS = "PartModules/Generic/Tooltip/Outputs";
    public const string TOOLTIP_HEAT_OUTPUT = "PartModules/Generic/Tooltip/HeatOutput";
    public const string TOOLTIP_COMMAND_CREW_REQUIRED = "PartModules/Command/Tooltip/CrewRequired";
    public const string TOOLTIP_COMMAND_COMMNET_REQUIRED = "PartModules/Command/Tooltip/CommnetRequired";
    public const string TOOLTIP_COMMAND_HIBERNATION_ALLOWED = "PartModules/Command/Tooltip/HibernationAllowed";
    public const string TOOLTIP_REACTIONWHEEL_TORQUE = "PartModules/ReactionWheel/Tooltip/Torque";
    public const string TOOLTIP_REACTIONWHEEL_PITCH = "PartModules/ReactionWheel/Tooltip/Pitch";
    public const string TOOLTIP_REACTIONWHEEL_YAW = "PartModules/ReactionWheel/Tooltip/Yaw";
    public const string TOOLTIP_REACTIONWHEEL_ROLL = "PartModules/ReactionWheel/Tooltip/Roll";
    public const string TOOLTIP_SOLARPANEL_DEPLOYABLE = "PartModules/SolarPanel/Tooltip/Deployable";
    public const string TOOLTIP_SOLARPANEL_NOT_RETRACTABLE = "PartModules/SolarPanel/Tooltip/NotRetractable";
    public const string TOOLTIP_RCS_MAXTHRUST = "PartModules/RCS/Tooltip/MaxThrust";
    public const string TOOLTIP_RCS_ISP = "PartModules/RCS/Tooltip/ISP";
    public const string TOOLTIP_ENGINE_MODES = "PartModules/Engine/Tooltip/Modes";
    public const string TOOLTIP_ENGINE_MAXTHRUST = "PartModules/Engine/Tooltip/MaxThrust";
    public const string TOOLTIP_ENGINE_ATM = "PartModules/Engine/Tooltip/Atm";
    public const string TOOLTIP_ENGINE_VAC = "PartModules/Engine/Tooltip/Vac";
    public const string TOOLTIP_ENGINE_MINTHRUST = "PartModules/Engine/Tooltip/MinThrust";
    public const string TOOLTIP_ENGINE_ISP = "PartModules/Engine/Tooltip/ISP";
    public const string TOOLTIP_ENGINE_HEAT = "PartModules/Engine/Tooltip/Heat";
    public const string TOOLTIP_ENGINE_FLAGS = "PartModules/Engine/Tooltip/Flags";
    public const string TOOLTIP_ENGINE_FLAG_NOSHUTDOWN = "PartModules/Engine/Tooltip/FlagNoShutdown";
    public const string TOOLTIP_ENGINE_FLAG_STOPS = "PartModules/Engine/Tooltip/FlagStops";
    public const string TOOLTIP_GIMBAL_VECTOR_RANGE = "PartModules/Gimbal/Tooltip/VectoringRange";
    public const string TOOLTIP_GIMBAL_YAW = "PartModules/Gimbal/Tooltip/Yaw";
    public const string TOOLTIP_GIMBAL_PITCH = "PartModules/Gimbal/Tooltip/Pitch";
    public const string TOOLTIP_DOCKING_CAPTURE_RANGE = "PartModules/Docking/Tooltip/CaptureRange";
    public const string TOOLTIP_DOCKING_EJECTION_FORCE = "PartModules/Docking/Tooltip/EjectionForce";
    public const string TOOLTIP_DOCKING_TYPES = "PartModules/Docking/Tooltip/Types";
    public const string TOOLTIP_DOCKING_TYPES_SLUG = "PartModules/Docking/Tooltip/Types/";
    public const string TOOLTIP_DECOUPLER_EJECTIONFORCE = "PartModules/Decoupler/Tooltip/EjectionForce";
    public const string TOOLTIP_DECOUPLER_OMNI = "PartModules/Decoupler/Tooltip/OmniDecouple";
    public const string TOOLTIP_INTAKE_RESOURCE = "PartModules/ResourceIntake/Tooltip/Resource";
    public const string TOOLTIP_INTAKE_AREA = "PartModules/ResourceIntake/Tooltip/Area";
    public const string TOOLTIP_INTAKE_EFFICIENCY = "PartModules/ResourceIntake/Tooltip/Efficiency";
    public const string TOOLTIP_INTAKE_EFFICIENCY_MACH = "PartModules/ResourceIntake/Tooltip/EfficiencyMach";
    public const string TOOLTIP_CONVERTER_MODES = "PartModules/ResourceConverter/Tooltip/Modes";
    public const string TOOLTIP_TRANSMITTER_MAXRANGE = "PartModules/DataTransmitter/Tooltip/MaxRange";
    public const string TOOLTIP_GENERATOR_ALWAYS_ACTIVE = "PartModules/Generator/Tooltip/AlwaysActive";
    public const string TOOLTIP_GENERATOR_ALTERNATOR = "PartModules/Generator/Tooltip/Alternator";
    public const string TOOLTIP_GENERATOR_DECAYS = "PartModules/Generator/Tooltip/OutputDecays";
    public const string TOOLTIP_GENERATOR_LIFETIME = "PartModules/Generator/Tooltip/Lifetime";
    public const string TOOLTIP_PARACHUTE_SAFE_VELOCITY = "PartModules/Parachute/Tooltip/SafeVelocity";
    public const string TOOLTIP_PARACHUTE_DRAG = "PartModules/Parachute/Tooltip/Drag";
    public const string TOOLTIP_PARACHUTE_SEMIDEPLOYED = "PartModules/Parachute/Tooltip/Semideployed";
    public const string TOOLTIP_PARACHUTE_DEPLOYED = "PartModules/Parachute/Tooltip/Deployed";
    public const double RATE_SECONDS_MIN = 0.001;
    public const double RATE_MINUTES_MIN = 0.001;
    public const double RATE_HOURS_MIN = 0.001;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTooltipResourceUnits(string resourceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FormatResourceRate(double rate, string units) => throw null;
  }
}
