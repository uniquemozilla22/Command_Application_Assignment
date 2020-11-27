using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationToDrawTheShapes
{
    public class Command_Implementation
    {
        String code, command;
        String[] error= {"",""};
        bool fill = false;
        public Command_Implementation(string code , string command){

            this.code = code;
            this.command = command;
            this.Implementation();
        }

        public void Implementation()
        {

            //converting the code to the lower case to be case insensative
            code = code.ToLower();
            command = command.ToLower();
            String[] code_arr = code.Split(' ');

            if (command == "run")
            {
                Code_Implementation coi= new Code_Implementation(code_arr);
            }
            else if (command == "clear")
            {
            }
            else if (command == "reset")
            {
            }
            else
            {
                error[1] = "**Please enter a valid command**";
            }
        }

        public string[] Error_Handling_CommandImplementation()
        {
            return this.error;
        }
    }
}
