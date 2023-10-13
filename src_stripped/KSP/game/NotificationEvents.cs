// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class NotificationEvents : KerbalMonoBehaviour
  {
    private const string VESSEL_RECOVERABLE_TITLE_KEY = "Flight/NotificationEvent/VesselRecoverableTitle";
    private const string ACTIVE_VESSEL_RECOVERABLE_KEY = "Flight/NotificationEvent/ActiveVesselRecoverable";
    private const string INACTIVE_VESSEL_RECOVERABLE_KEY = "Flight/NotificationEvent/InactiveVesselRecoverable";
    private const string OBSERVER_CANNOT_LEAVE_ACTIVE_VESSEL_KEY = "Flight/NotificationEvent/ObserverCannotLeaveActiveVessel";
    private const string VESSEL_LOST_CONTROL_TITLE_KEY = "Flight/NotificationEvent/VesselLostControlTitle";
    private const string VESSEL_LOST_CONTROL_KEY = "Flight/NotificationEvent/VesselLostControl";
    private const string INACTIVE_VESSEL_ON_CRASH_TRAJECTORY_TITLE_KEY = "Flight/NotificationEvent/InactiveVesselCrashCourseTitle";
    private const string INACTIVE_VESSEL_ON_CRASH_TRAJECTORY_KEY = "Flight/NotificationEvent/InactiveVesselCrashCourse";
    private const string AUTO_MODE_CAMERA_CONTEXT_KEY = "Flight/NotificationEvent/AutoModeCameraContext";
    private const string DEPLOYABLE_PART_AVAILABILITY_CHANGED_KEY = "Flight/NotificationEvent/DeployablePartAvailability";
    private const string DEPLOYABLE_PART_AVAILABILITY_CHANGED_TITLE_KEY = "Flight/NotificationEvent/DeployablePartAvailabilityTitle";
    private const string INACTIVE_VESSEL_NEAR_MANEUVER_TITLE_KEY = "Flight/NotificationEvent/InactiveVesselNearManeuverNodeTitle";
    private const string INACTIVE_VESSEL_NEAR_MANEUVER_KEY = "Flight/NotificationEvent/InactiveVesselNearManeuverNode";
    private const string SHOULD_DISPLAY_ERROR_MESSAGE_KEY = "VAB/NotificationEvent/ShouldDisplayErrorMessage";
    private const string MOUSELOOK_ACTIVATED_KEY = "Flight/NotificationEvent/MouselookActivated";
    private const string MOUSELOOK_DEACTIVATED_KEY = "Flight/NotificationEvent/MouselookDeactivated";
    private const string FLIGHT_NOTIFICATIONS_LOC_PATH = "Flight/NotificationEvent/";
    private const string DOCKING_CONTROLS_MESSAGE_KEY = "Flight/NotificationEvent/FlightControlsDocking";
    private const string NORMAL_CONTROLS_MESSAGE_KEY = "Flight/NotificationEvent/FlightControlsNormal";
    private const string ABLATOR_NOT_AVAILABLE_TITLE_KEY = "Flight/NotificationEvent/AblatorDepletedTitle";
    private const string ABLATOR_NOT_AVAILABLE_KEY = "Flight/NotificationEvent/AblatorDepleted";
    private const string PART_INEFFECTIVE_KEY = "Flight/NotificationEvent/PartIneffective";
    private const string INSUFFICIENT_STELLAR_EXPOSURE_KEY = "Flight/NotificationEvent/InsufficientStellarExposure";
    private const string VESSEL_OUT_OF_EC_TITLE_KEY = "PartModules/Electricity/NotificationEvent/OutOfECTitle";
    private const string VESSEL_OUT_OF_EC_KEY = "PartModules/Electricity/NotificationEvent/OutOfEC";
    private const string VESSEL_OUT_OF_COMMNET_RANGE_TITLE_KEY = "PartModules/DataTransmitter/NotificationEvent/OutOfCommNetRangeTitle";
    private const string VESSEL_OUT_OF_COMMNET_RANGE_KEY = "PartModules/DataTransmitter/NotificationEvent/OutOfCommNetRange";
    private const string TIMEWARP_DECREASING_APPROACHING_ORBITAL_EVENT_KEY = "Flight/NotificationEvent/TimewarpDecreasingApproachingOrbitalEvent";
    private const string THROTTLE_LOCKED_DUE_TO_TIMEWARP_KEY = "Flight/NotificationEvent/ThrottleLockedDueToTimewarp";
    private const string INACTIVE_VESSEL_ENTERED_SOI_TITLE_KEY = "Flight/NotificationEvent/InactiveVesselEnteredSOITitle";
    private const string INACTIVE_VESSEL_ENTERED_SOI_MESSAGE_KEY = "Flight/NotificationEvent/InactiveVesselEnteredSOI";
    private const string FORCE_TIMEWARP_DECREASE_KEY = "Flight/NotificationEvent/TimewarpForceDecrease";
    private const string TIMEWARP_CANT_INCREASE_DUE_TO_ALTITUDE_KEY = "Flight/NotificationEvent/TimewarpCantIncrease";
    private const string TIMEWARP_PAUSED_KEY = "TimeWarp/Pause";
    private const string TIMEWARP_UNPAUSED_KEY = "TimeWarp/Unpause";
    private const string MANEUVER_NODES_LOCKED_WHILE_OUT_OF_FUEL_KEY = "Map/OutOfFuelManeuverNode";
    private const string CANNOT_CHANGE_NODE_WHILE_OUT_OF_FUEL_KEY = "Map/CantChangeOutOfFuelManeuverNode";
    private const string ENGINE_IN_AIR_BREATHING_MODE = "Map/EngineInAirBreathingMode";
    private const string AUDIO_MUTED_KEY = "Application/Flow/MuteSound";
    private const string AUDIO_UNMUTED_KEY = "Application/Flow/UnmuteSound";
    private const string MUSIC_MUTED_KEY = "Application/Flow/MuteMusic";
    private const string MUSIC_UNMUTED_KEY = "Application/Flow/UnmuteMusic";
    [SerializeField]
    [Header("Flight")]
    private float _solarPanelsIneffectiveTimeBetweenNotifications;
    [SerializeField]
    private float _throttleLockedDueToTimewarpTimeBetweenNotifications;
    [SerializeField]
    private float _vesselLostControlTimeBetweenNotifications;
    private GameInstance _game;
    private SubscriptionHandle _debugVizualizerNotificationHandle;
    private SubscriptionHandle _vesselRecoverableNotificationHandle;
    private SubscriptionHandle _observerCannotLeaveActiveVesselNotificationHandle;
    private SubscriptionHandle _nonActiveVesselOnCrashTrajectoryNotificationHandle;
    private SubscriptionHandle _deployablePartAvailabilityChangedNotificationHandle;
    private SubscriptionHandle _nonActiveVesselNearManeuver;
    private SubscriptionHandle _oabUserMessageNotificationHandle;
    private SubscriptionHandle _shouldDisplayErrorMessageNotificationHandle;
    private SubscriptionHandle _invalidSymmetryAttachNotificationHandle;
    private SubscriptionHandle _invalidPartAnchorNotificationHandle;
    private SubscriptionHandle _oabPasteErrorNotificationHandle;
    private SubscriptionHandle _mouseLookActivatedNotificationHandle;
    private SubscriptionHandle _mouseLookDeactivatedNotificationHandle;
    private SubscriptionHandle _cameraModeKeyNotificationHandle;
    private SubscriptionHandle _autoModeCameraContextNotificationHandle;
    private SubscriptionHandle _flightControlsDockingNotificationHandle;
    private SubscriptionHandle _flightControlsNormalNotificationHandle;
    private SubscriptionHandle _ablatorAvailableNotificationHandle;
    private SubscriptionHandle _vesselLostControlNotificationHandle;
    private float _vesselLostControlTimeToWaitTill;
    private SubscriptionHandle _vesselInsufficientControlNotificationHandle;
    private SubscriptionHandle _vesselOutOfECNotificationHandle;
    private SubscriptionHandle _vesselLeftCommunicationRangeMessage;
    private SubscriptionHandle _solarPanelsIneffectiveNotificationHandle;
    private float _solarPanelsIneffectiveTimeToWaitTill;
    private SubscriptionHandle _throttleLockedDueToTimewarpHandle;
    private float _throttleLockedDueToTimewarpTimeToWaitTill;
    private SubscriptionHandle _inactiveVesselEnteredSOINotification;
    private SubscriptionHandle _timewarpCantIncreaseDueToAltitudeNotificationHandle;
    private SubscriptionHandle _timewarpDecreasingApproachingOrbitalEventNotificationHandle;
    private SubscriptionHandle _forceDecreaseTimewarpNotificationHandle;
    private SubscriptionHandle _gamePauseToggledNotificationHandle;
    private SubscriptionHandle _maneuversLockedWhileOutOfFuelHandle;
    private SubscriptionHandle _maneuverOutOfFuelHandle;
    private SubscriptionHandle _engineInAirBreathingModeHandle;
    private bool _isGamePaused;
    private SubscriptionHandle _muteAudioNoticationHandle;
    private SubscriptionHandle _muteMusicNoticationHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupNotificationEventSubscriptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugNotificationMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VesselRecoverable(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VesselLostControl(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselOutOfElectricity(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AblatorAvailableMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SolarPanelsIneffectiveMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NonActiveVesselOnCrashTrajectory(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NonActiveVesselNearManeuver(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselLeftCommunicationRangeMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InactiveVesselEnteredSOIMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OberserverCannotLeaveActiveVessel(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OABUserMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShouldDisplayErrorMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OABInvalidSymmetryAttachMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OABInvalidPartAnchorMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OABPasteErrorMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MouseLookActivatedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MouseLookDeactivatedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CameraModeKeyMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AutoModeCameraContextMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FlightControlsDockingMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FlightControlsNormalMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TimewarpCantIncreaseDueToAltitudeMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TimewarpDecreasingApproachingOrbitalEventMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceDecreaseTimewarpMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AudioMutedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MusicMutedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VesselThrottleLockedDueToTimewarpingMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CannotPlaceManeuverNodeWhileOutOfFuelMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CannotChangeNodeWhileOutOfFuelMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EngineInAirBreathingModeMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VesselInsufficientControlMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GamePauseToggledMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeployablePartAvailabilityChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationEvents() => throw null;
  }
}
