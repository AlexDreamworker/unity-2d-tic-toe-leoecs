using UnityEngine;

namespace TicTacToe
{
    [CreateAssetMenu]
    public class Configuration : ScriptableObject
    {
        public int BoardWidth = 3;
        public int BoardHeight = 3;
        public int ChainLength = 3;
        public CellView CellView;
        public Vector2 Offset;
        public SignView CrossView;
        public SignView RingView;
    }
}