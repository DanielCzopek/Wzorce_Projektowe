using System;
using System.Collections.Generic;

namespace Interpreter
{

    class Context
    {

        private string input;
        private int output;

        public Context(string input)
        {
            this.input = input;
        }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public int Output
        {
            get { return output; }
            set { output = value; }
        }

    }


    abstract class Phrase
    {

        public void Interpreter(Context context)
        {

            if (context.Input.Length == 0)
                return;

            /* UZUPEŁNIĆ kilka else a może while? */

        }

        public abstract string One();
        //
        public abstract int Multiplier();

    }


    class PhraseThousands : Phrase
    {
        public override string One() { return "M"; }
        public override string Four() { return " "; }
        public override string Five() { return " "; }
        public override string Nine() { return " "; }
        public override int Multiplier() { return 1000; }
    }
  