using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessBoardModel;
using System.Threading;

namespace ChessBoardGuiApp
{
    public partial class Form1 : Form
    {
        bool highE,highD;
        int highEasy, highDifficult;
        bool victory = false;
        bool once = false;
        bool Is_8 = false;
        int HighScore = 0;
        bool fromRestart = false;
        bool fromAuto = false;
        int count = 1;
        bool reset = false;
        public int[,] visited = new int[8, 8];
        public bool[,] nextmove = new bool[8, 8];
        public bool have_Previous = false;
        static Board myBoard = new Board(8);
        int index;
        public int[,] knightsvisit8 = new int[8, 8];
        public int[,] knightsvisit5 = new int[5, 5];
        public Button[,] btnGrid = new Button[myBoard.size, myBoard.size];
        Image black = Properties.Resources.black;
        Image white = Properties.Resources.white_bacckground;
        Image Icon = null;
        int[] currentloc = new int[2];
        int countV = 0;
        public Form1()
        {
            BIGB.Visible = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackgroundImage = Properties.Resources.tsvet_minimalizm_stil_fon_art_art_style_background_minima_15;
           
            InitializeComponent();
            Icon = Properties.Resources.imgknight__2_;
            populateGrid();
            panel2.BackgroundImage = (Image)Properties.Resources.max_yenin_by_max_yenin_knight_medieval_knight_character_vo_6;
            comboBox1.SelectedIndex = 0;
            index = comboBox1.SelectedIndex;

            gigP.Visible = false;
            for (int i = 0; i< myBoard.size; i++)
            {
                for(int j=0;j< myBoard.size; j++)
                {
                    knightsvisit8[i, j] = 0;
                    Is_8 = true;
                }
            }
            VCB.Text = "" + countV;
        }

        private void populateGrid()
        {
            int buttonSize = panel1.Width / myBoard.size;
            panel1.Height = panel1.Width;
            for (int i = 0; i < myBoard.size; i++)
            {
                for (int j = 0; j < myBoard.size; j++)  {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;
                    btnGrid[i, j].Click += Grid_Button_click;
                    panel1.Controls.Add(btnGrid[i, j]);
                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                    btnGrid[i, j].Tag = new Point(i, j);
                    
                }
            }
        }
        private void dePopulateGrid()
        {
            int buttonSize = panel1.Width / myBoard.size;
            for (int i = 0; i < myBoard.size; i++)
            {
                for (int j = 0; j < myBoard.size; j++)
                {
                    btnGrid[i, j].Hide();
                    btnGrid[i, j] = null;
                   
                }
            }
        }
        private void Grid_Button_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;
            int x = location.X;
            int y = location.Y;
            Cell currentCell = myBoard.theGrid[x, y];
            if (!reset)
            {  
                if (!have_Previous)
                {
                    myBoard.markNextLegalMove(currentCell);
                    for (int i = 0; i < myBoard.size; i++)
                    {
                        for (int j = 0; j < myBoard.size; j++)
                        {

                            if (myBoard.theGrid[i, j].legalNextMove)
                            {
                                nextmove[i, j] = true;
                            }
                        }
                    }

                    for (int i = 0; i < myBoard.size; i++)
                    {
                        for (int j = 0; j < myBoard.size; j++)
                        {
                            btnGrid[i, j].Text = " ";
                            if (myBoard.theGrid[i, j].legalNextMove)
                            {

                                btnGrid[i, j].Text = "Legal";
                            }
                            else if (myBoard.theGrid[i, j].currentlyOccupied)
                            {
                                visited[i, j] = count;
                                have_Previous = true;
                                btnGrid[i, j].BackgroundImage = Icon;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < myBoard.size; i++)
                    {
                        for (int j = 0; j < myBoard.size; j++)
                        {
                            if (nextmove[i, j] && x == i && y == j && !myBoard.theGrid[i, j].currentlyOccupied)
                            {
                                count++;
                                visited[i, j] = count;
                                myBoard.markNextLegalMove(currentCell);
                            }
                        }
                    }
                    for (int i = 0; i < myBoard.size; i++)
                    {
                        for (int j = 0; j < myBoard.size; j++)
                        {
                            nextmove[i, j] = false;
                        }
                    }
                    for (int i = 0; i < myBoard.size; i++)
                    {
                        for (int j = 0; j < myBoard.size; j++)
                        {

                            if (myBoard.theGrid[i, j].legalNextMove)
                            {
                                nextmove[i, j] = true;
                            }
                        }
                    }
                    for (int i = 0; i < myBoard.size; i++)
                    {
                        for (int j = 0; j < myBoard.size; j++)
                        {
                            btnGrid[i, j].Text = " ";
                            if (myBoard.theGrid[i, j].legalNextMove && myBoard.theGrid[i, j].currentlyOccupied == false)
                            {

                                btnGrid[i, j].Text = "Legal";
                            }
                            else if (myBoard.theGrid[i, j].currentlyOccupied)
                            {
                                have_Previous = true;
                                btnGrid[i, j].Text = "";
                                btnGrid[i, j].BackgroundImage = Icon;
                            }
                        }
                    }
                    bool flag = false;
                    for (int i = 0; i < myBoard.size; i++)
                    {
                        for (int j = 0; j < myBoard.size; j++)
                        {
                            if (myBoard.theGrid[i, j].legalNextMove && visited[i, j] == 0)
                            {
                                flag = true;
                            }
                        }
                    }
                    if (!flag)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            if (visited[currentCell.ColNumber, currentCell.RowNumber] > highDifficult)
                            {

                                highD = true;
                                highDifficult = visited[currentCell.ColNumber, currentCell.RowNumber];
                                HSCORE.Text = highDifficult + "";
                            }
                        }
                        else if(comboBox1.SelectedIndex == 1)
                        {
                            highE = true;
                            highEasy = visited[currentCell.ColNumber, currentCell.RowNumber];
                            HSCORE.Text = highEasy + "";
                        }
                        
                        if (!(visited[currentCell.ColNumber, currentCell.RowNumber] == 24 || visited[currentCell.ColNumber, currentCell.RowNumber] == 64))
                        {
                            if (MessageBox.Show("You Scored: " + visited[currentCell.ColNumber, currentCell.RowNumber] + "\n PlayAgain?", "Game Over!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                once = true;
                                resetOP();

                            }
                        }
                        else
                        {
                            countV++;
                            gigP.Visible = true;
                            for (int i = 0; i < 10; i++){
                                gigP.BackgroundImage = Properties.Resources.gigg;
                        }
                            VCB.Text = countV + "";
                        }

                     }
                }
            }
         }
        public void call()
        {
          
        }
        public void resetOP()
        {
            count = 0;
           
            {
                for (int i = 0; i < myBoard.size; i++)
                {
                    for (int j = 0; j < myBoard.size; j++)
                    {
                        visited[i, j] = 0;
                        nextmove[i, j] = false;
                        have_Previous = false;
                    }
                }
                for (int i = 0; i < myBoard.size; i++)
                {
                    for (int j = 0; j < myBoard.size; j++)
                    {
                        btnGrid[i, j].Text = " ";
                        if (myBoard.theGrid[i, j].legalNextMove && myBoard.theGrid[i, j].currentlyOccupied == false)
                        {

                            btnGrid[i, j].Text = "";
                        }
                        else if (myBoard.theGrid[i, j].currentlyOccupied)
                        {
                            have_Previous = true;
                            btnGrid[i, j].Text = "";
                            btnGrid[i, j].BackgroundImage = null;

                        }
                    }

                }

                myBoard.reset();
                have_Previous = false;
            }
           if(fromAuto)
            {
                if (Is_8)
                {
                    fromAuto = false;
                    knightsvisit8[0, 0] = 1;
                    knightstour(knightsvisit8, 0, 0, 1);
                    resetknight();
                    reset = false;
                }
                else
                {
                    fromAuto = false;
                    knightsvisit8[0, 0] = 1;
                    knightstour(knightsvisit5, 0, 0, 1);
                    resetknight();
                    reset = false;

                }
            }
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && index != comboBox1.SelectedIndex)
            {
                HSCORE.Text = highDifficult + "";
                Is_8 = true;
                resetOP();
                Icon = Properties.Resources.imgknight__2_;
                index = comboBox1.SelectedIndex;
                dePopulateGrid();
                myBoard.size = 8;
                populateGrid();
            }
            if (comboBox1.SelectedIndex == 1 && index != comboBox1.SelectedIndex)
            {
                HSCORE.Text = highEasy + "";
                Is_8 = false;
                resetOP();
                Icon = Properties.Resources.imgknight__1_;
                index = comboBox1.SelectedIndex;
                dePopulateGrid();
                myBoard.size = 5;
                populateGrid();
            }
        }
        public void resetknight()
        {
            if (Is_8)
            {
                for (int i = 0; i < knightsvisit8.GetLength(1); i++)
                {
                    for (int j = 0; j < knightsvisit8.GetLength(0); j++)
                    {
                        knightsvisit8[i, j] = 0;
                    }
                }
            }else
            {
                for (int i = 0; i < knightsvisit5.GetLength(1); i++)
                {
                    for (int j = 0; j < knightsvisit5.GetLength(0); j++)
                    {
                        knightsvisit5[i, j] = 0;
                    }
                }

            }
        }
       static public int[] colPath = { 1, 2, 2, 1, -1, -2, -2, -1 };

       static public int[] rowPath = { 2, 1, -1, -2, -2, -1, 1, 2 };
        public bool knightstour(int[,] knightsvisit, int row, int col, int key)
        {
            {
                if (knightsvisit.GetLength(0) == 8)
                {
                    if (key == 64)
                    {
                        for (int i = 0; i < rowPath.Length; i++)
                        {
                            for (int j = 0; j < rowPath.Length; j++)
                            {
                                btnGrid[i, j].Text = knightsvisit8[i, j] + " ";
                            }
                        }
                        return true;
                    }
                    else
                    {
                        for (int index = 0; index < colPath.Length; index++)
                        {
                            int rowNew = row + rowPath[index];
                            int colNew = col + colPath[index];
                            if (IsValidMove(knightsvisit, rowNew, colNew))
                            {
                                key++;
                                knightsvisit[rowNew, colNew] = key;
                                if (knightstour(knightsvisit, rowNew, colNew, key))
                                {
                                    return true;
                                }
                                key--;
                                knightsvisit[rowNew, colNew] = 0;
                            }
                        }
                    }
                    return false;
                }
            else{
                if (key == 25)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            
                            btnGrid[i, j].Text = knightsvisit5[i, j] + " ";
                            }
                    }
                    return true;
                }
                else
                {
                    for (int index = 0; index < colPath.Length; index++)
                    {
                        int rowNew = row + rowPath[index];
                        int colNew = col + colPath[index];
                        if (IsValidMove(knightsvisit, rowNew, colNew))
                        {
                            key++;
                            knightsvisit[rowNew, colNew] = key;
                            if (knightstour(knightsvisit, rowNew, colNew, key))
                            {
                                return true;
                            }
                            key--;
                            knightsvisit[rowNew, colNew] = 0;
                        }
                    }
                }
                return false;
            }
        }
        }
            static bool IsValidMove(int[,] knightsvisit, int rowNew, int colNew){

            {
                if (knightsvisit.GetLength(0) == 8)
                {
                    if (rowNew >= 0 && rowNew < 8 && colNew < 8 && colNew >= 0 && knightsvisit[rowNew, colNew] == 0)
                    {
                        return true;
                    }
                    return false;
                }
            else{
                if (rowNew >= 0 && rowNew < 5 && colNew < 5 && colNew >= 0 && knightsvisit[rowNew, colNew] == 0)
                {
                    return true;
                }
                return false;
            }
        }
            }
         private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BIGB.Visible = true;
            panel2.Hide();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fromRestart = true;
            resetOP();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            {
                reset = true;
                fromAuto = true;
                resetOP();
            }
          
        }

        private void gigP_Paint(object sender, PaintEventArgs e)
        {
            victory = true;
            Thread.Sleep(2000);
            gigP.Visible = false;
            fromRestart = true;
            resetOP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void VCB_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
