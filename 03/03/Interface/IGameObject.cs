using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Interface
{
    public enum GameObjectMedium { Paper, Plastic, Electronic }

    public interface IGameObject
    {

        int GameValue
        {
            get;
        }

        GameObjectMedium Medium
        {
            get;
        }
    }
}
