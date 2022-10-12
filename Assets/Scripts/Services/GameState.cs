using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;

namespace TicTacToe
{
    public class GameState 
    {
        public SignType CurrentType = SignType.Ring;
        public readonly Dictionary<Vector2Int, EcsEntity> Cells = new Dictionary<Vector2Int, EcsEntity>();
    }
}