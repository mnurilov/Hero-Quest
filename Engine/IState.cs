using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public interface IState 
    {
        //void Initialize();
        //void Pause();
        //void Resume();

        //void HandleEvents();
        void Update();
        void Update(Player player);
        void Draw();
    }
}
