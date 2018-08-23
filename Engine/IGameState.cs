using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public interface IGameState
    {
        //void Initialize();
        //void Pause();
        //void Resume();

        void HandleEvents();
        void Update();
        void Draw();
    }
}
