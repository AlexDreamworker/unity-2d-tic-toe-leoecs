using Leopotam.Ecs;
using UnityEngine;

namespace TicTacToe
{
    internal class SetCameraSystem : IEcsRunSystem
    {
        private EcsFilter<UpdateCameraEvent> _filter;
        private SceneData _sceneData;
        private Configuration _configuration;
        
        public void Run() //TODO: Refact
        {
            if (!_filter.IsEmpty()) 
            {
                var height = _configuration.BoardHeight;
                var width = _configuration.BoardWidth;
                
                var camera = _sceneData.Camera;
                camera.orthographic = true;
                camera.orthographicSize = height / 2f + (height - 1) * _configuration.Offset.y / 2;

                _sceneData.CameraTransform.position = new Vector3(
                    width / 2f + (width - 1) * _configuration.Offset.x / 2, 
                    height / 2f + (height - 1) * _configuration.Offset.y / 2
                    );
            }
        }
    }
}