using Leopotam.Ecs;

namespace TicTacToe
{
    public class AnalyzeClickedSystem : IEcsRunSystem
    {
        private EcsFilter<Cell, Clicked>.Exclude<Taken> _filter;
        private GameState _gameState;
        private SceneData _sceneData;

        public void Run()
        {
            foreach (var index in _filter)
            {
                ref var ecsEntity = ref _filter.GetEntity(index);
                ecsEntity.Get<Taken>().value = _gameState.CurrentType; //* "Set" - устанавливаем на компонент тип
                ecsEntity.Get<CheckWinEvent>(); //* "Set" - устанавливаем на компонент ивент
                
                _gameState.CurrentType = _gameState.CurrentType == SignType.Cross ? SignType.Ring : SignType.Cross;

                _sceneData.UI.GameHUD.SetTurn(_gameState.CurrentType);
            }
        }
    }
}