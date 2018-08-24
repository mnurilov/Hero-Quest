using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class IntroductionState : IState
    {
        public void Update()
        {
            InputManager.ManageIntroductionStateInput();
        }

        public void Update(Player player)
        {
            InputManager.ManageIntroductionStateInput();
        }

        public void Draw()
        {

        }
    }
}
