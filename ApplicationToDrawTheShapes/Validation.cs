﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationToDrawTheShapes
{
    public class Validation
    {

        string code;
        string command;
        string[] error={"",""};


        public Validation(string code , string command)
        {
            this.code = code;
            this.command = command;
            this.Validation_String();
        }
       

        public void Validation_String()
        {
            String validation_Text = "**This text feild is empty**";


            if (code == "" && command!= "")
            {
               
                this.error[0] = validation_Text;
                this.error[1] = "";
            }
            else if (command == "" && code != "")
            {
                this.error[1] = validation_Text;
                this.error[0] = "";
            }
            else if (command == "" && code == "")
            {
                this.error[0] = validation_Text;
                this.error[1] = validation_Text;
            }
            else if (command != "" && code != "")
            {
                code = code.ToLower();
                command = command.ToLower();
                String[] code_arr = code.Split(' ');
                Code_Implementation coi = new Code_Implementation(code_arr);
                this.error = coi.Error_Handling_CodeImplementation();


            }


        }

        public string[] Error_Handling_Validation()
        {

            return this.error;
        }



    }
}
