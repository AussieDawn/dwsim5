﻿using System;
using Eto.Forms;
using Eto.Drawing;

namespace DWSIM.UI.Forms
{
    public class FlowsheetObjectPanelItem: PixelLayout  
    {

        public ImageView imgIcon;
        public Label txtName, txtDescription;

        public static int width = (int)(GlobalSettings.Settings.UIScalingFactor * 300);

        public FlowsheetObjectPanelItem()
        {

            int padding = (int)(GlobalSettings.Settings.UIScalingFactor * 5);
            int height = (int)(GlobalSettings.Settings.UIScalingFactor * 70);

            int iconsize = height- (int)(GlobalSettings.Settings.UIScalingFactor * 6) * padding;

            Size = new Size(width, height);

            imgIcon = new ImageView() { Size = new Eto.Drawing.Size(iconsize, iconsize) };
            txtName = new Label() { Text = "Name", Font = SystemFonts.Bold() };
            txtDescription = new Label() { Text = "Description", Size = new Size(padding + width - (int)(GlobalSettings.Settings.UIScalingFactor * 10) - iconsize, height - (int)(GlobalSettings.Settings.UIScalingFactor * 20)) };

            txtName.Font = new Font(SystemFont.Bold, DWSIM.UI.Shared.Common.GetEditorFontSize());
            txtDescription.Font = new Font(SystemFont.Default, DWSIM.UI.Shared.Common.GetEditorFontSize());

            Add(imgIcon, padding, 3*padding);
            Add(txtName, padding+iconsize + (int)(GlobalSettings.Settings.UIScalingFactor * 6), padding);
            Add(txtDescription, padding+iconsize + (int)(GlobalSettings.Settings.UIScalingFactor * 6), padding+ (int)(GlobalSettings.Settings.UIScalingFactor * 16));

            MouseEnter += FlowsheetObjectPanelItem_MouseEnter;

            MouseLeave += FlowsheetObjectPanelItem_MouseLeave;

            if (!GlobalSettings.Settings.DarkMode) BackgroundColor = Colors.White; else BackgroundColor = Colors.Black;
            
        }

        private void FlowsheetObjectPanelItem_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!GlobalSettings.Settings.DarkMode)
            {
                BackgroundColor = Colors.White;
            }
            else
            {
                BackgroundColor = Colors.Black;
            }
        }

        private void FlowsheetObjectPanelItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if (GlobalSettings.Settings.DarkMode)
            {
                BackgroundColor = Colors.DarkGray;
            }
            else
            {
                BackgroundColor = Colors.LightSteelBlue;
            }
           
        }
    }
}
