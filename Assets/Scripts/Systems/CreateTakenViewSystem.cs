using Leopotam.Ecs;
using UnityEngine;

namespace TicTacToe
{
    public class CreateTakenViewSystem : IEcsRunSystem
    {
        private EcsFilter<Taken, CellViewRef>.Exclude<TakenRef> _filter;
        private Configuration _configuration;

        public void Run()
        {
            foreach (var index in _filter)
            {
                var position = _filter.Get2(index).value.transform.position;
                var takenType = _filter.Get1(index).value;

                SignView signView = null;
                switch (takenType)
                {
                    case SignType.Cross:
                        signView = _configuration.CrossView;
                        break;
                    case SignType.Ring:
                        signView = _configuration.RingView;
                        break;
                }

                var instance = Object.Instantiate(signView, position, Quaternion.identity);
                _filter.GetEntity(index).Get<TakenRef>().value = instance;
            }
        }
    }
}