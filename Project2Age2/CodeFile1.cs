using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class EnteringInteger{
    static void Main()
    {
        // текстовые переменые 
        string res, txt;
        // целочисленые переменые
        int year = 2021, age, born;
        // окно с полем ввода
        res = Interaction.InputBox("В каком году вы родились?", "Год рождения");
        // преоброзования текста в число
        born = Int32.Parse(res);
        // вычесление возроста
        age = year - born;
        txt = "тогда вам " + age + " лет";
        //онко с сообщением
        MessageBox.Show(txt, "Возраст");
    }
}