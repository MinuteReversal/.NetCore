using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class GameStart : ATextComponent
    {
        byte AnimateIndex = 0;

        /*

*  Snake

 SSSSSS                    kk  kk    
 SS                        kkkk
 SSSSSS  nnnnnn  aaaaaa    kkkk      eeeee
     SS  nn  nn  aa  aa    kk  kk    eee e
 SSSSSS  nn  nn  aaaaaaa   kk   kk   eeeeeeee
 */
        List<string> words = new List<string>(){
                {"SSSSSS                    kk  kk"},
                {"SS                        kkkk"},
                {"SSSSSS  nnnnnn  aaaaaa    kkkk      eeeee"},
                {"    SS  nn  nn  aa  aa    kk  kk    eee e"},
                {"SSSSSS  nn  nn  aaaaaaa   kk   kk   eeeeeeee"},
                {""},
                {""},
                {"        Press any Button to Start"}
            };

        public GameStart()
        {
            this.shape = this.CreateShape(this.words);
        }

        public override void Frame()
        {
            if (this.AnimateIndex == 0)
            {
                this.words[this.words.Count - 1] = "";
                this.AnimateIndex = 1;
            }
            else
            {
                this.words[this.words.Count - 1] = "        Press any Button to Start";
                this.AnimateIndex = 0;
            }
            this.shape = this.CreateShape(this.words);            
        }
    }
}