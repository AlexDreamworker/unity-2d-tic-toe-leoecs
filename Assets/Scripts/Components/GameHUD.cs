using System;
using TMPro;
using UnityEngine;

namespace TicTacToe
{
    public class GameHUD : MonoBehaviour
    {
        public TMP_Text TurnLabel;

        public void SetTurn(SignType currentType)
        {
            switch(currentType) 
            {
                case SignType.Cross:
                    TurnLabel.text = "Is RED turn";
                    break;
                case SignType.Ring:
                    TurnLabel.text = "Is BLUE turn";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(currentType), currentType, null);
            }
        }
    }
}