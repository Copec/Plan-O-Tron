using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plan_o_Tron_6000.UI
{
    /// <summary>
    /// Für den Debug Mode. 
    /// http://en.wikipedia.org/wiki/Konami_Code
    /// </summary>
    public class KonamiSequence
    {
        List<Keys> Keys = new List<Keys>{System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Up, 
                                       System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Down, 
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right, 
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right, 
                                       System.Windows.Forms.Keys.B, System.Windows.Forms.Keys.A};
        private int mPosition = -1;

        public int Position
        {
            get { return mPosition; }
            private set { mPosition = value; }
        }

        public bool IsCompletedBy(Keys key)
        {

            if (Keys[Position + 1] == key)
            {
                // move to next
                Position++;
            }
            else if (Position == 1 && key == System.Windows.Forms.Keys.Up)
            {
                // stay where we are
            }
            else if (Keys[0] == key)
            {
                // restart at 1st
                Position = 0;
            }
            else
            {
                // no match in sequence
                Position = -1;
            }

            if (Position == Keys.Count - 1)
            {
                Position = -1;
                return true;
            }

            return false;
        }
    }


    //public class KonamiSequence
    //{
    //    readonly Keys[] _code = { Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Left, Keys.Right, Keys.Left, Keys.Right, Keys.B, Keys.A };

    //    private int _offset;
    //    private readonly int _length, _target;

    //    public KonamiSequence()
    //    {
    //        _length = _code.Length - 1;
    //        _target = _code.Length;
    //    }

    //    public bool IsCompletedBy(Keys key)
    //    {
    //        _offset %= _target;

    //        if (key == _code[_offset]) _offset++;
    //        else if (key == _code[0]) _offset = 2;  // repeat index

    //        return _offset > _length;
    //    }
    //}
}
