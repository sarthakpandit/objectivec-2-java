﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objcDeofuscator;

using System.Text.RegularExpressions;

namespace ObjcDeofuscatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbIn_TextChanged(object sender, EventArgs e)
        {
            string s = tbIn.Text;

           
           
            IProcess pre = new Preprocessor( Regex.Split(s, "\r\n"));
            List<string> preResult = pre.Process();
            IProcess procesado = new Processor(preResult);
            List<string> procesadoResult = procesado.Process();
            foreach (string line in procesadoResult) 
            {
                tbOut.AppendText(line + "\r\n");
            }

           

        }


    }
}
