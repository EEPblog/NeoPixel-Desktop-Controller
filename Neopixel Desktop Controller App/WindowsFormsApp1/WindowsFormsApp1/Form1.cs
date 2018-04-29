using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int mode, spd, r, g, b;
        int lmode, lspd, lr, lg, lb;

        private void btnStaticColor_Click(object sender, EventArgs e)
        {
            mode = 2;
            r = trackBarStaticColorRed.Value;
            g = trackBarStaticColorGreen.Value;
            b = trackBarStaticColorBlue.Value;
            panelTheatreChaseLights.Visible = false;
            panelBeacon.Visible = false;
            PanelHue.Visible = false;
            PanelBreathing.Visible = false;
            panelKnightRider.Visible = false;
            panelManageConnections.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = false;
            PanelStaticColor.Visible = true;
            pictureBox1.Location = new Point(246, 109);
            btnStaticColor.BackColor = Color.FromArgb(58, 58, 58);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            
        }

        private void btnHue_Click(object sender, EventArgs e)
        {
            if (checkBoxHueLoopmode.Checked)
            {
                mode = 1;
            }
            else
            {
                mode = 6;
            }
            spd = trackBarHueSpd.Value;
            panelTheatreChaseLights.Visible = false;
            panelBeacon.Visible = false;
            PanelStaticColor.Visible = false;
            PanelBreathing.Visible = false;
            panelKnightRider.Visible = false;
            panelManageConnections.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = false;
            PanelHue.Visible = true;
            pictureBox1.Location = new Point(246, 70);
            btnHue.BackColor = Color.FromArgb(58, 58, 58);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            
        }

        private void btnBreathing_Click(object sender, EventArgs e)
        {
            mode = 3;
            r = trackBarBreathingRed.Value;
            g = trackBarBreathingGreen.Value;
            b = trackBarBreathingBlue.Value;
            spd = trackBarBreathingSpd.Value;
            panelTheatreChaseLights.Visible = false;
            panelBeacon.Visible = false;
            PanelStaticColor.Visible = false;
            PanelHue.Visible = false;
            panelKnightRider.Visible = false;
            panelManageConnections.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = false;
            PanelBreathing.Visible = true;
            pictureBox1.Location = new Point(246, 148);
            btnBreathing.BackColor = Color.FromArgb(58, 58, 58);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            
        }

        private void btnBeacon_Click(object sender, EventArgs e)
        {
            mode = 4;
            r = trackBarBeaconRed.Value;
            g = trackBarBeaconGreen.Value;
            b = trackBarBeaconBlue.Value;
            spd = trackBarBeaconSpd.Value;
            panelTheatreChaseLights.Visible = false;
            PanelStaticColor.Visible = false;
            PanelHue.Visible = false;
            PanelBreathing.Visible = false;
            panelKnightRider.Visible = false;
            panelManageConnections.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = false;
            panelBeacon.Visible = true;
            pictureBox1.Location = new Point(246, 187);
            btnBeacon.BackColor = Color.FromArgb(58, 58, 58);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            
        }

        private void btnTheatreChaseLights_Click(object sender, EventArgs e)
        {
            if (checkBoxTheatreChaseLightsColorWheel.Checked)
            {
                panelTheatreChaseLights2.Enabled = false;
                mode = 5;
            }
            else
            {
                panelTheatreChaseLights2.Enabled = true;
                mode = 7;
            }
            r = trackBarTheatreChaseLightsRed.Value;
            g = trackBarTheatreChaseLightsGreen.Value;
            b = trackBarTheatreChaseLightsBlue.Value;
            spd = trackBarTheatreChaseLightsSpd.Value;
            PanelStaticColor.Visible = false;
            PanelHue.Visible = false;
            PanelBreathing.Visible = false;
            panelBeacon.Visible = false;
            panelKnightRider.Visible = false;
            panelManageConnections.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = false;
            panelTheatreChaseLights.Visible = true;
            pictureBox1.Location = new Point(246, 226);
            btnTheatreChaseLights.BackColor = Color.FromArgb(58, 58, 58);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            
        }

        private void btnKnightRider_Click(object sender, EventArgs e)
        {
            mode = 8;
            r = trackBarKnightRiderRed.Value;
            g = trackBarKnightRiderGreen.Value;
            b = trackBarKnightRiderBlue.Value;
            spd = trackBarKnightRiderSpd.Value;
            PanelStaticColor.Visible = false;
            PanelHue.Visible = false;
            PanelBreathing.Visible = false;
            panelBeacon.Visible = false;
            panelTheatreChaseLights.Visible = false;
            panelManageConnections.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = false;
            panelKnightRider.Visible = true;
            pictureBox1.Location = new Point(246, 265);
            btnKnightRider.BackColor = Color.FromArgb(58, 58, 58);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
            
        }

        private void btnManageConnections_Click(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            foreach (string comport in ports)
            {
                comboBox1.Items.Add(comport);
            }
            PanelStaticColor.Visible = false;
            PanelHue.Visible = false;
            PanelBreathing.Visible = false;
            panelBeacon.Visible = false;
            panelTheatreChaseLights.Visible = false;
            panelKnightRider.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = false;
            panelManageConnections.Visible = true;
            pictureBox1.Location = new Point(246, 484);
            btnManageConnections.BackColor = Color.FromArgb(58, 58, 58);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
        }

        private void btnAudioMeter_Click(object sender, EventArgs e)
        {
            mode = 9;
            if (checkBoxAudioMeterChangeColor.Checked)
            {
                panelAudiometer2.Enabled = true;
                spd = 1;
            }
            else
            {
                panelAudiometer2.Enabled = false;
                spd = 0;
            }
            r = trackBarAudioMeterRed.Value;
            g = trackBarAudioMeterGreen.Value;
            b = trackBarAudioMeterBlue.Value;
            PanelStaticColor.Visible = false;
            PanelHue.Visible = false;
            PanelBreathing.Visible = false;
            panelBeacon.Visible = false;
            panelTheatreChaseLights.Visible = false;
            panelKnightRider.Visible = false;
            panelManageConnections.Visible = false;
            panelOff.Visible = false;
            panelAudioMeter.Visible = true;
            pictureBox1.Location = new Point(246, 304);
            btnAudioMeter.BackColor = Color.FromArgb(58, 58, 58);
            btnOff.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
            
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            PanelStaticColor.Visible = false;
            PanelHue.Visible = false;
            PanelBreathing.Visible = false;
            panelBeacon.Visible = false;
            panelTheatreChaseLights.Visible = false;
            panelKnightRider.Visible = false;
            panelManageConnections.Visible = false;
            panelAudioMeter.Visible = false;
            panelOff.Visible = true;
            pictureBox1.Location = new Point(246, 342);
            btnOff.BackColor = Color.FromArgb(58, 58, 58);
            btnAudioMeter.BackColor = Color.FromArgb(53, 53, 53);
            btnManageConnections.BackColor = Color.FromArgb(53, 53, 53);
            btnKnightRider.BackColor = Color.FromArgb(53, 53, 53);
            btnTheatreChaseLights.BackColor = Color.FromArgb(53, 53, 53);
            btnBeacon.BackColor = Color.FromArgb(53, 53, 53);
            btnBreathing.BackColor = Color.FromArgb(53, 53, 53);
            btnStaticColor.BackColor = Color.FromArgb(53, 53, 53);
            btnHue.BackColor = Color.FromArgb(53, 53, 53);
            mode = 2;
            r = 0;
            g = 0;
            b = 0;
            
        }

        private void trackBarStaticColorRed_Scroll(object sender, EventArgs e)
        {
            r = trackBarStaticColorRed.Value;
            numericUpDownStaticColorRed.Value = r;
            
        }

        private void numericUpDownStaticColorRed_ValueChanged(object sender, EventArgs e)
        {
            r = Convert.ToInt16(numericUpDownStaticColorRed.Value);
            trackBarStaticColorRed.Value = r;
            
        }

        private void trackBarStaticColorGreen_Scroll(object sender, EventArgs e)
        {
            g = trackBarStaticColorGreen.Value;
            numericUpDownStaticColorGreen.Value = g;
            
        }

        private void numericUpDownStaticColorGreen_ValueChanged(object sender, EventArgs e)
        {
            g = Convert.ToInt16(numericUpDownStaticColorGreen.Value);
            trackBarStaticColorGreen.Value = g;
            
        }

        private void trackBarStaticColorBlue_Scroll(object sender, EventArgs e)
        {
            b = trackBarStaticColorBlue.Value;
            numericUpDownStaticColorBlue.Value = b;
            
        }

        private void numericUpDownStaticColorBlue_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(numericUpDownStaticColorBlue.Value);
            trackBarStaticColorBlue.Value = b;
            
        }

        private void trackBarBeaconRed_Scroll(object sender, EventArgs e)
        {
            r = trackBarBeaconRed.Value;
            numericUpDownBeaconRed.Value = r;
            
        }

        private void numericUpDownBeaconRed_ValueChanged(object sender, EventArgs e)
        {
            r = Convert.ToInt16(numericUpDownBeaconRed.Value);
            trackBarBeaconRed.Value = r;
            
        }

        private void trackBarBeaconGreen_Scroll(object sender, EventArgs e)
        {
            g = trackBarBeaconGreen.Value;
            numericUpDownBeaconGreen.Value = g;
            
        }

        private void numericUpDownBeaconGreen_ValueChanged(object sender, EventArgs e)
        {
            g = Convert.ToInt16(numericUpDownBeaconGreen.Value);
            trackBarBeaconGreen.Value = g;
            
        }

        private void trackBarBeaconBlue_Scroll(object sender, EventArgs e)
        {
            b = trackBarBeaconBlue.Value;
            numericUpDownBeaconBlue.Value = b;
            
        }

        private void numericUpDownBeaconBlue_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(numericUpDownBeaconBlue.Value);
            trackBarBeaconBlue.Value = b;
            
        }

        private void trackBarBeaconSpd_Scroll(object sender, EventArgs e)
        {
            spd = trackBarBeaconSpd.Value;
            numericUpDownBeaconSpd.Value = spd;
            
        }

        private void numericUpDownBeaconSpd_ValueChanged(object sender, EventArgs e)
        {
            spd = Convert.ToInt16(numericUpDownBeaconSpd.Value);
            trackBarBeaconSpd.Value = spd;
            
        }

        private void trackBarBreathingRed_Scroll(object sender, EventArgs e)
        {
            r = trackBarBreathingRed.Value;
            numericUpDownBreathingRed.Value = r;
            
        }

        private void numericUpDownBreathingRed_ValueChanged(object sender, EventArgs e)
        {
            r = Convert.ToInt16(numericUpDownBreathingRed.Value);
            trackBarBreathingRed.Value = r;
            
        }

        private void trackBarBreathingGreen_Scroll(object sender, EventArgs e)
        {
            g = trackBarBreathingGreen.Value;
            numericUpDownBreathingGreen.Value = g;
            
        }

        private void numericUpDownBreathingGreen_ValueChanged(object sender, EventArgs e)
        {
            g = Convert.ToInt16(numericUpDownBreathingGreen.Value);
            trackBarBreathingGreen.Value = g;
            
        }

        private void trackBarBreathingBlue_Scroll(object sender, EventArgs e)
        {
            b = trackBarBreathingBlue.Value;
            numericUpDownBreathingBlue.Value = b;
            
        }

        private void numericUpDownBreathingBlue_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(numericUpDownBreathingBlue.Value);
            trackBarBreathingBlue.Value = b;
            
        }

        private void trackBarBreathingSpd_Scroll(object sender, EventArgs e)
        {
            spd = trackBarBreathingSpd.Value;
            numericUpDownBreathingSpd.Value = spd;
            
        }

        private void numericUpDownBreathingSpd_ValueChanged(object sender, EventArgs e)
        {
            spd = Convert.ToInt16(numericUpDownBreathingSpd.Value);
            trackBarBreathingSpd.Value = spd;
            
        }

        private void trackBarTheatreChaseLightsRed_Scroll(object sender, EventArgs e)
        {
            r = trackBarTheatreChaseLightsRed.Value;
            numericUpDownTheatreChaseLightsRed.Value = r;
            
        }

        private void numericUpDownTheatreChaseLightsRed_ValueChanged(object sender, EventArgs e)
        {
            r = Convert.ToInt16(numericUpDownTheatreChaseLightsRed.Value);
            trackBarTheatreChaseLightsRed.Value = r;
            
        }

        private void trackBarTheatreChaseLightsGreen_Scroll(object sender, EventArgs e)
        {
            g = trackBarTheatreChaseLightsGreen.Value;
            numericUpDownTheatreChaseLightsGreen.Value = g;
            
        }

        private void numericUpDownTheatreChaseLightsGreen_ValueChanged(object sender, EventArgs e)
        {
            g = Convert.ToInt16(numericUpDownTheatreChaseLightsGreen.Value);
            trackBarTheatreChaseLightsGreen.Value = g;
            
        }

        private void trackBarTheatreChaseLightsBlue_Scroll(object sender, EventArgs e)
        {
            b = trackBarTheatreChaseLightsBlue.Value;
            numericUpDownTheatreChaseLightsBlue.Value = b;
            
        }

        private void numericUpDownTheatreChaseLightsBlue_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(numericUpDownTheatreChaseLightsBlue.Value);
            trackBarTheatreChaseLightsBlue.Value = b;
            
        }

        private void trackBarTheatreChaseLightsSpd_Scroll(object sender, EventArgs e)
        {
            spd = trackBarTheatreChaseLightsSpd.Value;
            numericUpDownTheatreChaseLightsSpd.Value = spd;
            
        }

        private void numericUpDownTheatreChaseLightsSpd_ValueChanged(object sender, EventArgs e)
        {
            spd = Convert.ToInt16(numericUpDownTheatreChaseLightsSpd.Value);
            trackBarTheatreChaseLightsSpd.Value = spd;
            
        }

        private void trackBarKnightRiderRed_Scroll(object sender, EventArgs e)
        {
            r = trackBarKnightRiderRed.Value;
            numericUpDownKnightRiderRed.Value = r;
            
        }

        private void numericUpDownKnightRiderRed_ValueChanged(object sender, EventArgs e)
        {
            r = Convert.ToInt16(numericUpDownKnightRiderRed.Value);
            trackBarKnightRiderRed.Value = r;
            
        }

        private void trackBarKnightRiderGreen_Scroll(object sender, EventArgs e)
        {
            g = trackBarKnightRiderGreen.Value;
            numericUpDownKnightRiderGreen.Value = g;
            
        }

        private void numericUpDownKnightRiderGreen_ValueChanged(object sender, EventArgs e)
        {
            g = Convert.ToInt16(numericUpDownKnightRiderGreen.Value);
            trackBarKnightRiderGreen.Value = g;
            
        }

        private void trackBarKnightRiderBlue_Scroll(object sender, EventArgs e)
        {
            b = trackBarKnightRiderBlue.Value;
            numericUpDownKnightRiderBlue.Value = b;
            
        }

        private void numericUpDownKnightRiderBlue_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(numericUpDownKnightRiderBlue.Value);
            trackBarKnightRiderBlue.Value = b;
            
        }

        private void trackBarKnightRiderSpd_Scroll(object sender, EventArgs e)
        {
            spd = trackBarKnightRiderSpd.Value;
            numericUpDownKnightRiderSpd.Value = spd;
            
        }

        private void numericUpDownKnightRiderSpd_ValueChanged(object sender, EventArgs e)
        {
            spd = Convert.ToInt16(numericUpDownKnightRiderSpd.Value);
            trackBarKnightRiderSpd.Value = spd;
            
        }

        private void trackBarAudioMeterRed_Scroll(object sender, EventArgs e)
        {
            r = trackBarAudioMeterRed.Value;
            numericUpDownAudioMeterRed.Value = r;
            trackBarAudioMeterGreen.Maximum = r;
            numericUpDownAudioMeterGreen.Maximum = r;
            trackBarAudioMeterBlue.Maximum = g;
            numericUpDownAudioMeterBlue.Maximum = g;
            
        }

        private void numericUpDownAudioMeterRed_ValueChanged(object sender, EventArgs e)
        {

            r = Convert.ToInt16(numericUpDownAudioMeterRed.Value);
            trackBarAudioMeterRed.Value = r;
            trackBarAudioMeterGreen.Maximum = r;
            numericUpDownAudioMeterGreen.Maximum = r;
            trackBarAudioMeterBlue.Maximum = g;
            numericUpDownAudioMeterBlue.Maximum = g;
            
        }

        private void trackBarAudioMeterGreen_Scroll(object sender, EventArgs e)
        {
            g = trackBarAudioMeterGreen.Value;
            numericUpDownAudioMeterGreen.Value = g;
            trackBarAudioMeterBlue.Maximum = g;
            numericUpDownAudioMeterBlue.Maximum = g;
            
        }

        private void numericUpDownAudioMeterGreen_ValueChanged(object sender, EventArgs e)
        {

            g = Convert.ToInt16(numericUpDownAudioMeterGreen.Value);
            trackBarAudioMeterGreen.Value = g;
            trackBarAudioMeterBlue.Maximum = g;
            numericUpDownAudioMeterBlue.Maximum = g;
            
        }

        private void trackBarAudioMeterBlue_Scroll(object sender, EventArgs e)
        {

            b = trackBarAudioMeterBlue.Value;
            numericUpDownAudioMeterBlue.Value = b;
            
        }

        private void numericUpDownAudioMeterBlue_ValueChanged(object sender, EventArgs e)
        {

            b = Convert.ToInt16(numericUpDownAudioMeterBlue.Value);
            trackBarAudioMeterBlue.Value = b;
            
        }

        private void checkBoxTheatreChaseLightsColorWheel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTheatreChaseLightsColorWheel.Checked)
            {
                panelTheatreChaseLights2.Enabled = false;
                mode = 5;
            }
            else
            {
                panelTheatreChaseLights2.Enabled = true;
                mode = 7;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                var port = comboBox1.SelectedItem.ToString();
                serialPort1.PortName = port;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        StatusLine.ForeColor = Color.Orange;
                        StatusLine.Text = "Verifying " + port;
                        serialPort1.Open();
                        serialPort1.WriteLine("S,1,0,0,0,0,0\n");
                        serialPort1.Close();
                        StatusLine.ForeColor = Color.Lime;
                        StatusLine.Text = "Connected to " + port;
                        panelModesGreyOut.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("An error occured while trying to access " + port + "! Please verify, that the device is connected to your computer and that the COM port you've chosen is correct!", "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StatusLine.ForeColor = Color.OrangeRed;
                        StatusLine.Text = "Error on " + port;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the port first!", "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxAudioMeterChangeColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAudioMeterChangeColor.Checked)
            {
                panelAudiometer2.Enabled = true;
                spd = 1;
            }
            else
            {
                panelAudiometer2.Enabled = false;
                spd = 0;
            }
            
        }

        private void checkBoxHueLoopmode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHueLoopmode.Checked)
            {
                mode = 1;
            }
            else
            {
                mode = 6;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!(lmode == mode && lspd == spd && lr == r && lg == g && lb == b))
            {
                string StringToSend = "S," + "0," + Convert.ToString(mode) + "," + Convert.ToString(spd) + "," + Convert.ToString(r) + "," + Convert.ToString(g) + "," + Convert.ToString(b) + "\n";

                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        serialPort1.Write(StringToSend);
                        label26.Text = StringToSend;
                        serialPort1.Close();
                    }
                    catch
                    {
                        MessageBox.Show("An error occured while trying to access device! Please verify, that the device is connected to your computer and that the COM port you've chosen is correct!", "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StatusLine.ForeColor = Color.OrangeRed;
                        StatusLine.Text = "Communication Error";
                    }
                }
                lmode = mode;
                lspd = spd;
                lr = r;
                lg = g;
                lb = b;
            }
        }

        public Form1()
        {
            InitializeComponent();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            foreach (string comport in ports)
            {
                comboBox1.Items.Add(comport);
            }
            pictureBox1.Location = new Point(246, 484);
        }

        private void trackBarHueSpd_Scroll(object sender, EventArgs e)
        {
            spd = trackBarHueSpd.Value;
            numericUpDownHueSpd.Value = spd;
            
        }

        private void numericUpDownHueSpd_ValueChanged(object sender, EventArgs e)
        {
            spd = Convert.ToInt16(numericUpDownHueSpd.Value);
            trackBarHueSpd.Value = spd;
            
        }

    }
}