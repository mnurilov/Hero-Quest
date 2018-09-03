using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class GameStateManager
    {
        public static Stack<IState> states = new Stack<IState>();

        public static void Push(IState state)
        {
            states.Push(state);
        }

        public static void Pop()
        {
            states.Pop();
        }

        public static void Set(IState state)
        {
            states.Pop();
            states.Push(state);
        }

        public static void Peek()
        {
            states.Peek();
        }

        public static void Update(Player player)
        {
            states.Peek().Update(player);
        }
    }
}
