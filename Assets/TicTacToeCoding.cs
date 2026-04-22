using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeCoding : MonoBehaviour
{
    Boolean checker;
    Boolean btn1Checked = false;
    Boolean btn2Checked = false;
    Boolean btn3Checked = false;
    Boolean btn4Checked = false;
    Boolean btn5Checked = false;
    Boolean btn6Checked = false;
    Boolean btn7Checked = false;
    Boolean btn8Checked = false;
    Boolean btn9Checked = false;
    int plusOne;

    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;

    public Text btnReset = null;
    public Text btnNew = null;
    public Text feedback = null;

    public Text txtX;
    public Text txtO;

    public void score()
    {
        // PLAYER X 
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.red;
            btnText4.color = Color.red;
            btnText7.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
        {
            btnText1.color = Color.red;
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            btnText3.color = Color.red;
            btnText5.color = Color.red;
            btnText7.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            btnText2.color = Color.red;
            btnText5.color = Color.red;
            btnText8.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X")
        {
            btnText3.color = Color.red;
            btnText6.color = Color.red;
            btnText9.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            btnText4.color = Color.red;
            btnText5.color = Color.red;
            btnText6.color = Color.red;
            feedback.text = "Player X won!";
            plusOne = int.Parse(txtX.text);
            txtX.text = Convert.ToString(plusOne + 1);
        }
        else
        // PLAYER O
        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            btnText1.color = Color.blue;
            btnText2.color = Color.blue;
            btnText3.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O")
        {
            btnText1.color = Color.blue;
            btnText5.color = Color.blue;
            btnText9.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            btnText3.color = Color.blue;
            btnText5.color = Color.blue;
            btnText7.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            btnText2.color = Color.blue;
            btnText5.color = Color.blue;
            btnText8.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            btnText7.color = Color.blue;
            btnText8.color = Color.blue;
            btnText9.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O")
        {
            btnText3.color = Color.blue;
            btnText6.color = Color.blue;
            btnText9.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            btnText4.color = Color.blue;
            btnText5.color = Color.blue;
            btnText6.color = Color.blue;
            feedback.text = "Player O won!";
            plusOne = int.Parse(txtO.text);
            txtO.text = Convert.ToString(plusOne + 1);
        }
        else
        if (btn1Checked == true && btn2Checked == true && btn3Checked == true && btn4Checked == true && btn5Checked == true && btn6Checked == true && btn7Checked == true && btn8Checked == true && btn9Checked == true) 
        {
            feedback.text = "A draw! Reset the game.";
        }
    }

    public void btnText1Click() 
    {
        if (checker == false && btn1Checked == false) 
        {
            btnText1.text = "X";
            checker = true;
            btn1Checked = true;
        }
        else
        if (btn1Checked == false)
        {
            btnText1.text = "O";
            checker = false;
            btn1Checked = true;
        }
        score();
    }

    public void btnText2Click() 
    {
        if (checker == false && btn2Checked == false) 
        {
            btnText2.text = "X";
            checker = true;
            btn2Checked = true;
        }
        else 
        if (btn2Checked == false)
        {
            btnText2.text = "O";
            checker = false;
            btn2Checked = true;
        }
        score();
    }

    public void btnText3Click() 
    {
        if (checker == false && btn3Checked == false) 
        {
            btnText3.text = "X";
            checker = true;
            btn3Checked = true;
        }
        else 
        if (btn3Checked == false)
        {
            btnText3.text = "O";
            checker = false;
            btn3Checked = true;
        }
        score();
    }

    public void btnText4Click() 
    {
        if (checker == false && btn4Checked == false) 
        {
            btnText4.text = "X";
            checker = true;
            btn4Checked = true;
        }
        else 
        if (btn4Checked == false)
        {
            btnText4.text = "O";
            checker = false;
            btn4Checked = true;
        }
        score();
    }

    public void btnText5Click() 
    {
        if (checker == false && btn5Checked == false) 
        {
            btnText5.text = "X";
            checker = true;
            btn5Checked = true;
        }
        else 
        if (btn5Checked == false)
        {
            btnText5.text = "O";
            checker = false;
            btn5Checked = true;
        }
        score();
    }

    public void btnText6Click() 
    {
        if (checker == false && btn6Checked == false) 
        {
            btnText6.text = "X";
            checker = true;
            btn6Checked = true;
        }
        else 
        if (btn6Checked == false)
        {
            btnText6.text = "O";
            checker = false;
            btn6Checked = true;
        }
        score();
    }

    public void btnText7Click() 
    {
        if (checker == false && btn7Checked == false) 
        {
            btnText7.text = "X";
            checker = true;
            btn7Checked = true;
        }
        else 
        if (btn7Checked == false)
        {
            btnText7.text = "O";
            checker = false;
            btn7Checked = true;
        }
        score();
    }

    public void btnText8Click() 
    {
        if (checker == false && btn8Checked == false) 
        {
            btnText8.text = "X";
            checker = true;
            btn8Checked = true;
        }
        else 
        if (btn8Checked == false)
        {
            btnText8.text = "O";
            checker = false;
            btn8Checked = true;
        }
        score();
    }

    public void btnText9Click() 
    {
        if (checker == false && btn9Checked == false) 
        {
            btnText9.text = "X";
            checker = true;
            btn9Checked = true;
        }
        else 
        if (btn9Checked == false)
        {
            btnText9.text = "O";
            checker = false;
            btn9Checked = true;
        }
        score();
    }

    public void btnResetClick() 
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

        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;

        btn1Checked = false;
        btn2Checked = false;
        btn3Checked = false;
        btn4Checked = false;
        btn5Checked = false;
        btn6Checked = false;
        btn7Checked = false;
        btn8Checked = false;
        btn9Checked = false;

        feedback.text = "";
        checker = false;
    }

    public void btnNewClick()
    {
        btnResetClick();
        txtX.text = "0";
        txtO.text = "0";
    }
}

