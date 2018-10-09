using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class GameStateStack
    {
        public static Stack<State> states = new Stack<State>();

        public static void Push(State state)
        {
            states.Push(state);
        }

        public static void Pop()
        {
            states.Pop();
        }

        public static void Set(State state)
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
