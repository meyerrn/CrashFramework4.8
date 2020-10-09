using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashFramework48
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
	}

	public class ComboBoxCrash : ComboBox
	{
		protected override AccessibleObject CreateAccessibilityInstance()
		{
			return new ControlAccessibleObject(this);
		}
	}

}
