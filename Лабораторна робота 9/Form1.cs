using System;
using System.Drawing;
using System.Windows.Forms;

namespace Лабораторна_робота_9
{
    public partial class Form1 : Form
    {
        private Button _buttonRozrahunok;
        private Button _buttonExit;
        private Label _coordinates;
        private Label _speed;
        private Label _acceleration;
        private Label _t0;
        private Label _t1;
        private Label _t2;
        private Label _LawOfMovement;
        private Label _LawOfMovementFormula;
        private Form2 form2;
        private TextBox _grid00;
        private TextBox _grid01;
        private TextBox _grid02;
        private TextBox _grid10;
        private TextBox _grid11;
        private TextBox _grid12;
        private TextBox _grid20;
        private TextBox _grid21;
        private TextBox _grid22;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private ToolTip toolTip7;
        private ToolTip toolTip8;
        private ToolTip toolTip9;

        public Form1()
        {

            InitializeComponent();
            _t0 = new Label();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddMyGroupBox();
            AddButtons();
            AddLabels();
        }
        private void AddMyGroupBox()
        {
            //GroupBox
            //
            GroupBox groupBox = new GroupBox();
            groupBox.Size = new Size(250, 85);
            groupBox.Location = new Point(20, 220);
            groupBox.Font = new Font("Microsoft Sans Sherif", 12);
            groupBox.Text = "Режим роботи";
            //
            //RadioButton for "розрахунок"
            //
            RadioButton radioButtonCalculus = new RadioButton();
            radioButtonCalculus.Location = new Point(10, 25);
            radioButtonCalculus.Text = "Режим розрахунку";
            radioButtonCalculus.Size = new Size(200, 25);
            radioButtonCalculus.TextAlign = ContentAlignment.MiddleLeft;
            //
            //Radio button action for "Розрахунок"
            //
            radioButtonCalculus.CheckedChanged += buttonCalculus_CheckedChanged;
            //
            //radioButton  for "перевірка"
            //
            RadioButton radioButtonCheking = new RadioButton();
            radioButtonCheking.Location = new Point(10, 50);
            radioButtonCheking.Text = "Режим перевірки";
            radioButtonCheking.Size = new Size(200, 25);
            //
            //RadioButton actiond for "перевірка"
            //
            radioButtonCheking.CheckedChanged += buttonChecking_CheckedChanged;
            //
            //Adding RadioButtons in GroupBox
            //
            groupBox.Controls.Add(radioButtonCalculus);
            groupBox.Controls.Add(radioButtonCheking);
            //
            //Loading custom GroupBox
            //
            this.Controls.Add(groupBox);
        }
        private void buttonCalculus_CheckedChanged(object sender, EventArgs e) //Show menu
        {
            _buttonRozrahunok.Text = "Розрахунок";
            if (_buttonRozrahunok.Visible == false)
            {
                MenuVisibleTrue();
                AddTextBoxGridview();
            }

        }
        private void MenuVisibleTrue()
        {
            _buttonRozrahunok.Visible = true;
            _buttonExit.Visible = true;
            _coordinates.Visible = true;
            _speed.Visible = true;
            _acceleration.Visible = true;
            _t0.Visible = true;
            _t1.Visible = true;
            _t2.Visible = true;
            _LawOfMovement.Visible = true;
            _LawOfMovementFormula.Visible = true;
        }
        private void buttonChecking_CheckedChanged(object sender, EventArgs e)
        {
            _buttonRozrahunok.Text = "Перевірка";
        }
        private void _buttonRozrahunok_Click(object sender, EventArgs e)
        {
            if (_buttonRozrahunok.Text == "Розрахунок")
            {
                SetColorAfterCheck();
                GridTableUpdate();
            }
            else
            {
                CordRightCheck();
                SpeedRightCheck();
                AccelerationCheck();
            }
        }
        private void AddButtons()
        {
            //
            //Add Button for "Розразунок"
            //
            _buttonRozrahunok = new Button();
            _buttonRozrahunok.Size = new Size(120, 30);
            _buttonRozrahunok.Location = new Point(370, 225);
            _buttonRozrahunok.Text = "Розрахунок";
            _buttonRozrahunok.Font = new Font("Microsoft Sans Sherif", 12);
            _buttonRozrahunok.Visible = false;
            _buttonRozrahunok.Click += _buttonRozrahunok_Click;
            this.Controls.Add(_buttonRozrahunok);
            //
            //Add button for "Вийти"
            //
            _buttonExit = new Button();
            _buttonExit.Size = new Size(120, 30);
            _buttonExit.Location = new Point(370, 275);
            _buttonExit.Text = "Вийти";
            _buttonExit.Font = new Font("Microsoft Sans Sherif", 12);
            _buttonExit.Click += _buttonExit_Click;
            _buttonExit.Visible = false;
            this.Controls.Add(_buttonExit);
            //
            //Add Click action on every Label t0
            //
            _t0.Click += Label_Click;
        }

        private void _buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddLabels()
        {
            //
            //Defining labels
            //
            _coordinates = new Label();
            _speed = new Label();
            _acceleration = new Label();
            _t0 = new Label();
            _t1 = new Label();
            _t2 = new Label();
            _LawOfMovement = new Label();
            _LawOfMovementFormula = new Label();
            //
            //Action for t0.Click
            //
            _t0.Click += Label_Click;
            //
            //Labels.Visible=false;
            //
            _coordinates.Visible = false;
            _speed.Visible = false;
            _acceleration.Visible = false;
            _t0.Visible = false;
            _t1.Visible = false;
            _t2.Visible = false;
            _LawOfMovement.Visible = false;
            _LawOfMovementFormula.Visible = false;
            //
            //Text in labels
            //
            _coordinates.Text = "Кордината:";
            _speed.Text = "Швідкість:";
            _speed.Size = new Size(90, 20);
            _acceleration.Text = "Прискорення:";
            _acceleration.Size = new Size(115, 20);
            _t0.Text = "t0";
            _t1.Text = "t1";
            _t2.Text = "t2";
            _LawOfMovement.Text = "Закон руху";
            _LawOfMovementFormula.Text = "x = 2sin(\u03C0t^2/2+0.1)";
            _LawOfMovementFormula.Size = new Size(210, 20);
            //
            //Location of labels
            //
            _coordinates.Location = new Point(30, 120);
            _speed.Location = new Point(40, 140);
            _acceleration.Location = new Point(13, 160);
            _t0.Location = new Point(165, 100);
            _t1.Location = new Point(268, 100);
            _t2.Location = new Point(368, 100);
            _LawOfMovement.Location = new Point(235, 10);
            _LawOfMovementFormula.Location = new Point(193, 35);
            //
            //Label fonts
            //
            _coordinates.Font = new Font("Microsoft Sans Sherif", 12);
            _speed.Font = new Font("Microsoft Sans Sherif", 12);
            _acceleration.Font = new Font("Microsoft Sans Sherif", 12);
            _t0.Font = new Font("Microsoft Sans Sherif", 12);
            _t1.Font = new Font("Microsoft Sans Sherif", 12);
            _t2.Font = new Font("Microsoft Sans Sherif", 12);
            _LawOfMovement.Font = new Font("Microsoft Sans Sherif", 12);
            _LawOfMovementFormula.Font = new Font("Microsoft Sans Sherif", 14);
            //
            //Add in control
            //
            this.Controls.Add(_coordinates);
            this.Controls.Add(_speed);
            this.Controls.Add(_acceleration);
            this.Controls.Add(_t0);
            this.Controls.Add(_t1);
            this.Controls.Add(_t2);
            this.Controls.Add(_LawOfMovement);
            this.Controls.Add(_LawOfMovementFormula);
        }
        private void AddTextBoxGridview()
        {
            //
            //Initialize text boxes
            //
            _grid00 = new TextBox();
            _grid01 = new TextBox();
            _grid02 = new TextBox();
            _grid10 = new TextBox();
            _grid11 = new TextBox();
            _grid12 = new TextBox();
            _grid20 = new TextBox();
            _grid21 = new TextBox();
            _grid22 = new TextBox();
            //
            //Row 1 
            //
            _grid00.Location = new Point(130, 122);
            _grid01.Location = new Point(228, 122);
            _grid02.Location = new Point(326, 122);
            //
            //Row 2
            //
            _grid10.Location = new Point(130, 141);
            _grid11.Location = new Point(228, 141);
            _grid12.Location = new Point(326, 141);
            //
            //Row3
            //
            _grid20.Location = new Point(130, 159);
            _grid21.Location = new Point(228, 159);
            _grid22.Location = new Point(326, 159);
            //
            //Table size
            //
            _grid00.Size = new Size(100, 31);
            _grid01.Size = new Size(100, 31);
            _grid02.Size = new Size(100, 31);
            _grid10.Size = new Size(100, 31);
            _grid11.Size = new Size(100, 31);
            _grid12.Size = new Size(100, 31);
            _grid20.Size = new Size(100, 31);
            _grid21.Size = new Size(100, 31);
            _grid22.Size = new Size(100, 31);
            //
            //Adding on form;
            //
            this.Controls.Add(_grid00);
            this.Controls.Add(_grid01);
            this.Controls.Add(_grid02);
            this.Controls.Add(_grid10);
            this.Controls.Add(_grid11);
            this.Controls.Add(_grid12);
            this.Controls.Add(_grid20);
            this.Controls.Add(_grid21);
            this.Controls.Add(_grid22);
            //
            //Add tool tips;
            //
            _grid00.Click += _grid00ShowToolTip_Click;
            _grid01.Click += _grid01ShowToolTip_Click;
            _grid02.Click += _grid02ShowToolTip_Click;
            _grid10.Click += _grid10ShowToolTip_Click;
            _grid11.Click += _grid11ShowToolTip_Click;
            _grid12.Click += _grid12ShowToolTip_Click;
            _grid20.Click += _grid20ShowToolTip_Click;
            _grid21.Click += _grid21ShowToolTip_Click;
            _grid22.Click += _grid22ShowToolTip_Click;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.ShowDialog();
        }
        //
        //Math part start
        //
        const double pi = 3.14;
        double[] functionCordPackage = new double[3];
        double[] functionSpeedPackage = new double[3];
        double[] functionAccelerationPackage = new double[3];
        public double[] CoordinateInGrid()
        {
            if (form2 == null)
            {
                for (int i = 0; i < functionCordPackage.Length; i++)
                {
                    double coordinateX = 0;
                    functionCordPackage[i] = coordinateX;
                }
            }
            else
            {
                for (int i = 0; i < functionCordPackage.Length; i++)
                {
                    double coordinateX = Math.Round(2 * Math.Sin(pi * (Math.Pow(i * form2.GetTimeIncrement(), 2) / 2) + 0.1), 4);
                    functionCordPackage[i] = coordinateX;
                }
            }


            return functionCordPackage;
        }
        public double[] SpeedInGrid()
        {
            if (form2 == null)
            {
                for (int i = 0; i < functionSpeedPackage.Length; i++)
                {
                    functionSpeedPackage[i] = functionCordPackage[i];
                }
            }
            else
            {
                for (int i = 0; i < functionSpeedPackage.Length; i++)
                {
                    functionSpeedPackage[i] = functionCordPackage[i] / (i * form2.GetTimeIncrement());
                }

            }
            functionSpeedPackage[0] = 0;
            return functionSpeedPackage;
        }
        private double[] AccelerationInGrid()
        {

            if (form2 == null)
            {
                for (int i = 0; i < functionAccelerationPackage.Length; i++)
                {
                    functionAccelerationPackage[i] = functionSpeedPackage[i];
                }
            }
            else
            {
                for (int i = 0; i < functionAccelerationPackage.Length; i++)
                {
                    functionAccelerationPackage[i] = functionSpeedPackage[i] / (i * form2.GetTimeIncrement());
                }
            }
            functionAccelerationPackage[0] = 0;
            return functionAccelerationPackage;
        }
        //
        //Math part end
        //
        public void GridTableUpdate()
        {
            CoordinateInGrid();
            SpeedInGrid();
            AccelerationInGrid();

            _grid00.Text = Convert.ToString(functionCordPackage[0]);
            _grid01.Text = Convert.ToString(functionCordPackage[1]);
            _grid02.Text = Convert.ToString(functionCordPackage[2]);

            _grid10.Text = Convert.ToString(functionSpeedPackage[0]);
            _grid11.Text = Convert.ToString(functionSpeedPackage[1]);
            _grid12.Text = Convert.ToString(functionSpeedPackage[2]);

            _grid20.Text = Convert.ToString(functionAccelerationPackage[0]);
            _grid21.Text = Convert.ToString(functionAccelerationPackage[1]);
            _grid22.Text = Convert.ToString(functionAccelerationPackage[2]);
        }

        private void CordRightCheck()
        {
            if (_grid00.Text == Convert.ToString(functionCordPackage[0])) { _grid00.BackColor = Color.Green; }
            else { _grid00.BackColor = Color.Red; }

            if (_grid01.Text == Convert.ToString(functionCordPackage[1])) { _grid01.BackColor = Color.Green; }
            else { _grid01.BackColor = Color.Red; }

            if (_grid02.Text == Convert.ToString(functionCordPackage[2])) { _grid02.BackColor = Color.Green; }
            else { _grid02.BackColor = Color.Red; }
        }

        private void SpeedRightCheck()
        {
            if (_grid10.Text == Convert.ToString(functionSpeedPackage[0])) { _grid10.BackColor = Color.Green; }
            else { _grid10.BackColor = Color.Red; }

            if (_grid11.Text == Convert.ToString(functionSpeedPackage[1])) { _grid11.BackColor = Color.Green; }
            else { _grid11.BackColor = Color.Red; }

            if (_grid12.Text == Convert.ToString(functionSpeedPackage[2])) { _grid12.BackColor = Color.Green; }
            else { _grid12.BackColor = Color.Red; }
        }

        private void AccelerationCheck()
        {
            if (_grid20.Text == Convert.ToString(functionAccelerationPackage[0])) { _grid20.BackColor = Color.Green; }
            else { _grid20.BackColor = Color.Red; }

            if (_grid21.Text == Convert.ToString(functionAccelerationPackage[1])) { _grid21.BackColor = Color.Green; }
            else { _grid21.BackColor = Color.Red; }

            if (_grid22.Text == Convert.ToString(functionAccelerationPackage[2])) { _grid22.BackColor = Color.Green; }
            else { _grid22.BackColor = Color.Red; }
        }

        private void SetColorAfterCheck()
        {
            _grid00.BackColor = Color.White;
            _grid01.BackColor = Color.White;
            _grid02.BackColor = Color.White;
            _grid10.BackColor = Color.White;
            _grid11.BackColor = Color.White;
            _grid12.BackColor = Color.White;
            _grid20.BackColor = Color.White;
            _grid21.BackColor = Color.White;
            _grid22.BackColor = Color.White;
        }

        private void _grid00ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(this._grid00, "x = 2sin(πt^2/2+0.1)");
        }
        private void _grid01ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip2 = new ToolTip();
            toolTip2.AutoPopDelay = 5000;
            toolTip2.InitialDelay = 1000;
            toolTip2.ReshowDelay = 500;

            toolTip2.SetToolTip(this._grid01, "x = 2sin(π(t+time increment)^2/2+0.1)");
        }
        private void _grid02ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip3 = new ToolTip();
            toolTip3.AutoPopDelay = 5000;
            toolTip3.InitialDelay = 1000;
            toolTip3.ReshowDelay = 500;

            toolTip3.SetToolTip(this._grid02, "x = 2sin(π(t+(2 * time increment))^2/2+0.1)");
        }
        private void _grid10ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip4 = new ToolTip();
            toolTip4.AutoPopDelay = 5000;
            toolTip4.InitialDelay = 1000;
            toolTip4.ReshowDelay = 500;

            toolTip4.SetToolTip(this._grid10, "v = dX / dT");
        }
        private void _grid11ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip5 = new ToolTip();
            toolTip5.AutoPopDelay = 5000;
            toolTip5.InitialDelay = 1000;
            toolTip5.ReshowDelay = 500;

            toolTip5.SetToolTip(this._grid11, "v = dX / d(T + time increment)");
        }
        private void _grid12ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip6 = new ToolTip();
            toolTip6.AutoPopDelay = 5000;
            toolTip6.InitialDelay = 1000;
            toolTip6.ReshowDelay = 500;

            toolTip6.SetToolTip(this._grid12, "v = dX / d(T + (time increment * 2)");
        }
        private void _grid20ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip7 = new ToolTip();
            toolTip7.AutoPopDelay = 5000;
            toolTip7.InitialDelay = 1000;
            toolTip7.ReshowDelay = 500;

            toolTip7.SetToolTip(this._grid20, "a = dV / dT");
        }
        private void _grid21ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip8 = new ToolTip();
            toolTip8.AutoPopDelay = 5000;
            toolTip8.InitialDelay = 1000;
            toolTip8.ReshowDelay = 500;

            toolTip8.SetToolTip(this._grid21, "a = dV / d(T + time increment)");
        }
        private void _grid22ShowToolTip_Click(object sender, EventArgs e)
        {
            toolTip9 = new ToolTip();
            toolTip9.AutoPopDelay = 5000;
            toolTip9.InitialDelay = 1000;
            toolTip9.ReshowDelay = 500;

            toolTip9.SetToolTip(this._grid22, "a = dV / d(T + (time increment * 2)");
        }
    }
}