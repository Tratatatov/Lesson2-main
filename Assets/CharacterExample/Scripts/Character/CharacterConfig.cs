using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private SprintingStateConfig _sprintingStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;
    [SerializeField] private WalkingStateConfig _walkingStateConfig;

    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public SprintingStateConfig SprintingStateConfig => _sprintingStateConfig;
    public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
}
