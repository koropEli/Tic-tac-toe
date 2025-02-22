using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TicTacToe : MonoBehaviour
{
    Boolean checker;
    int plusone;

    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;

    public Text btnResetGame = null;
    public Text btnNewGame = null;
    public Text msgFeedback = null;
    public Text txtPlayerX = null;
    public Text txtPlayerO = null;

    public void score()
    {
        // Check for Player X's win conditions
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText2.color = Color.cyan;
            btnText3.color = Color.cyan;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (plusone + 1).ToString();
        }

        if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.red;
            btnText4.color = Color.red;
            btnText7.color = Color.red;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (plusone + 1).ToString();
        }

        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (plusone + 1).ToString();
        }

        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            btnText2.color = Color.blue;
            btnText5.color = Color.blue;
            btnText8.color = Color.blue;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (plusone + 1).ToString();
        }

        if (btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X")
        {
            btnText3.color = Color.green;
            btnText6.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (plusone + 1).ToString();
        }

        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            btnText4.color = Color.magenta;
            btnText5.color = Color.magenta;
            btnText6.color = Color.magenta;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (plusone + 1).ToString();
        }

        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            btnText7.color = Color.yellow;
            btnText8.color = Color.yellow;
            btnText9.color = Color.yellow;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = (plusone + 1).ToString();
        }

        // Check for Player O's win conditions
        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            btnText1.color = Color.cyan;
            btnText2.color = Color.cyan;
            btnText3.color = Color.cyan;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (plusone + 1).ToString();
        }

        if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.red;
            btnText4.color = Color.red;
            btnText7.color = Color.red;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (plusone + 1).ToString();
        }

        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (plusone + 1).ToString();
        }

        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            btnText2.color = Color.blue;
            btnText5.color = Color.blue;
            btnText8.color = Color.blue;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (plusone + 1).ToString();
        }

        if (btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O")
        {
            btnText3.color = Color.green;
            btnText6.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (plusone + 1).ToString();
        }

        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            btnText4.color = Color.magenta;
            btnText5.color = Color.magenta;
            btnText6.color = Color.magenta;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (plusone + 1).ToString();
        }

        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            btnText7.color = Color.yellow;
            btnText8.color = Color.yellow;
            btnText9.color = Color.yellow;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = (plusone + 1).ToString();
        }
    }

    public void btnText1_Click()
    {
        if (checker == false) 
        {
            btnText1.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText1.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnText2_Click()
    {
        if (checker == false) 
        {
            btnText2.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText2.text = "O"; 
            checker = false;
        }
        score();
    }


    public void btnText3_Click()
    {
        if (checker == false) 
        {
            btnText3.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText3.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnText4_Click()
    {
        if (checker == false) 
        {
            btnText4.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText4.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnText5_Click()
    {
        if (checker == false) 
        {
            btnText5.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText5.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnText6_Click()
    {
        if (checker == false) 
        {
            btnText6.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText6.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnText7_Click()
    {
        if (checker == false) 
        {
            btnText7.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText7.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnText8_Click()
    {
        if (checker == false) 
        {
            btnText8.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText8.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnText9_Click()
    {
        if (checker == false) 
        {
            btnText9.text = "X"; 
            checker = true;
        }
        else 
        {
            btnText9.text = "O"; 
            checker = false;
        }
        score();
    }

    public void btnResetGame_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";

        btnText1.color = Color.black; btnText2.color = Color.black;
        btnText3.color = Color.black; btnText4.color = Color.black;
        btnText5.color = Color.black; btnText6.color = Color.black;
        btnText7.color = Color.black; btnText8.color = Color.black;
    }
    public void btnNewGame_Click()
    {
        btnResetGame_Click();
        txtPlayerX.text = "";
        txtPlayerO.text = "";
    }


}
