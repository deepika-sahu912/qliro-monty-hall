using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunSimulator;

namespace Qliro.MontyHallSimulator
{
    public partial class Simulator : Form
    {
        private static GenerateSimulation _runSimulation =new GenerateSimulation();
        private static Calculate _calcPerc = new Calculate();
        public Simulator()
        {
            InitializeComponent();
            winResult.Visible = false;
            loseResult.Visible = false;
            winPercentage.Visible = false;
            winResultValue.Visible = false;
            lostResultValue.Visible = false;
            winPercValue.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numberOfTimesToRun = Int32.Parse(textBox1.Text);
           bool switchdoor = checkBox1.Checked;
            RunGame(numberOfTimesToRun, switchdoor);
           
        }

        public void RunGame(int timesToRun, bool switchDoors)
        {
            for (int i = 0; i < timesToRun; i++)
            {
                _runSimulation.InitalizeList();
                _runSimulation.ChooseDoor();
                _runSimulation.RemoveDoor();
                _runSimulation.ChosenDoor = _runSimulation.SwitchDoor(switchDoors);
                var win = _runSimulation.CheckIfCarChosen();
                if (win == true) _calcPerc.WinCount++;
                if (win == false) _calcPerc.LossCount++;
            }

            winResult.Visible = true;
            loseResult.Visible = true;
            winPercentage.Visible = true;
            winResultValue.Visible = true;
            lostResultValue.Visible = true;
            winPercValue.Visible = true;

            winResultValue.Text = _calcPerc.WinCount.ToString();
            lostResultValue.Text = _calcPerc.LossCount.ToString();
            _calcPerc.ComputePercentage();
            winPercValue.Text =  _calcPerc.PercentWins.ToString();

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loseResult_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
