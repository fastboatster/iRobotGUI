﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace iRobotGUI
{
	/// <summary>
	/// Interaction logic for ForwardWindow.xaml
	/// </summary>
	public partial class DriveWindow : BaseParamWindow
	{
		public DriveWindow()
		{
			InitializeComponent();
		}

		public override Instruction Ins
		{
			get
			{
				return controlInstance.Ins;
			}
			set
			{
				controlInstance.Ins = value;
			}
		}
	}
}
