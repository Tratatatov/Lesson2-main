public class SprintingState : GroundedState
{
    private SprintingStateConfig _config;

    public SprintingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.SprintingStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartSprinting();
        Data.Speed = _config.Speed;
    }
    public override void Exit()
    {
        base.Exit();
        View.StopSprinting();
    }
    public override void Update()
    {
        base.Update();

        if (IsSprintButtonPressed() == false)
            StateSwitcher.SwitchState<RunningState>();

        if (IsWalkButtonPressed())
        {
            StateSwitcher.SwitchState<WalkingState>();
        }

        if (IsHorizonatalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
