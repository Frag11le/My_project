using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApp1
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002658 File Offset: 0x00000858
		public Form1()
		{
			base.Load += this.Form1_Load;
			this.interval = 10;
			this.x = 10;
			this.y = 10;
			this.isPressed = 0;
			this.ms = 1;
			this.InitializeComponent();
		}

		// Token: 0x06000026 RID: 38
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000027 RID: 39
		[DllImport("user32.dll")]
		private static extern int BlockInput(int fBlock);

		// Token: 0x06000028 RID: 40
		[DllImport("user32.dll")]
		public static extern long ShowCursor(long lShow);

		// Token: 0x06000029 RID: 41 RVA: 0x00002175 File Offset: 0x00000375
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		// Token: 0x0600002B RID: 43 RVA: 0x000026B8 File Offset: 0x000008B8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (Form1.GetAsyncKeyState(Keys.LButton) != 0 && Control.IsKeyLocked(Keys.Capital))
				{
					if (Operators.ConditionalCompareObjectEqual(Operators.ModObject(this.ms, 2), 0, false))
					{
						Form1.mouse_event(1, this.x, 0 - this.y, 0, 0);
					}
					else
					{
						Form1.mouse_event(1, 0 - this.x, this.y, 0, 0);
					}
					ref object ptr = ref this.ms;
					this.ms = Operators.AddObject(ptr, 1);
					return;
				}
				this.ms = 1;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002178 File Offset: 0x00000378
		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.Timer1.Interval = Convert.ToInt32(this.NumericUpDown1.Value);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002197 File Offset: 0x00000397
		private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			this.x = Convert.ToInt32(this.NumericUpDown2.Value);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021B0 File Offset: 0x000003B0
		private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			this.y = Convert.ToInt32(this.NumericUpDown3.Value);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002197 File Offset: 0x00000397
		private void NumericUpDown2_KeyUp(object sender, KeyEventArgs e)
		{
			this.x = Convert.ToInt32(this.NumericUpDown2.Value);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021B0 File Offset: 0x000003B0
		private void NumericUpDown3_KeyUp(object sender, KeyEventArgs e)
		{
			this.y = Convert.ToInt32(this.NumericUpDown3.Value);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002178 File Offset: 0x00000378
		private void NumericUpDown1_KeyUp(object sender, KeyEventArgs e)
		{
			this.Timer1.Interval = Convert.ToInt32(this.NumericUpDown1.Value);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000021C9 File Offset: 0x000003C9
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002CA4 File Offset: 0x00000EA4
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000021D3 File Offset: 0x000003D3
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000021DD File Offset: 0x000003DD
		internal virtual Timer Timer2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000021F0 File Offset: 0x000003F0
		internal virtual Timer Timer3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000021F9 File Offset: 0x000003F9
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002203 File Offset: 0x00000403
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000220C File Offset: 0x0000040C
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002CE8 File Offset: 0x00000EE8
		internal virtual NumericUpDown NumericUpDown1
		{
			[CompilerGenerated]
			get
			{
				return this._NumericUpDown1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NumericUpDown1_ValueChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.NumericUpDown1_KeyUp);
				NumericUpDown numericUpDown = this._NumericUpDown1;
				if (numericUpDown != null)
				{
					numericUpDown.ValueChanged -= value2;
					numericUpDown.KeyUp -= value3;
				}
				this._NumericUpDown1 = value;
				numericUpDown = this._NumericUpDown1;
				if (numericUpDown != null)
				{
					numericUpDown.ValueChanged += value2;
					numericUpDown.KeyUp += value3;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002216 File Offset: 0x00000416
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002D48 File Offset: 0x00000F48
		internal virtual NumericUpDown NumericUpDown2
		{
			[CompilerGenerated]
			get
			{
				return this._NumericUpDown2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NumericUpDown2_ValueChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.NumericUpDown2_KeyUp);
				NumericUpDown numericUpDown = this._NumericUpDown2;
				if (numericUpDown != null)
				{
					numericUpDown.ValueChanged -= value2;
					numericUpDown.KeyUp -= value3;
				}
				this._NumericUpDown2 = value;
				numericUpDown = this._NumericUpDown2;
				if (numericUpDown != null)
				{
					numericUpDown.ValueChanged += value2;
					numericUpDown.KeyUp += value3;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000222A File Offset: 0x0000042A
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002233 File Offset: 0x00000433
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002DA8 File Offset: 0x00000FA8
		internal virtual NumericUpDown NumericUpDown3
		{
			[CompilerGenerated]
			get
			{
				return this._NumericUpDown3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NumericUpDown3_ValueChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.NumericUpDown3_KeyUp);
				NumericUpDown numericUpDown = this._NumericUpDown3;
				if (numericUpDown != null)
				{
					numericUpDown.ValueChanged -= value2;
					numericUpDown.KeyUp -= value3;
				}
				this._NumericUpDown3 = value;
				numericUpDown = this._NumericUpDown3;
				if (numericUpDown != null)
				{
					numericUpDown.ValueChanged += value2;
					numericUpDown.KeyUp += value3;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000223D File Offset: 0x0000043D
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002247 File Offset: 0x00000447
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0400000E RID: 14
		public const int VK_LBUTTON = 1;

		// Token: 0x0400000F RID: 15
		public const int VK_RBUTTON = 2;

		// Token: 0x04000010 RID: 16
		public const int VK_XBUTTON1 = 5;

		// Token: 0x04000011 RID: 17
		public const int VK_XBUTTON2 = 6;

		// Token: 0x04000012 RID: 18
		private int interval;

		// Token: 0x04000013 RID: 19
		private int x;

		// Token: 0x04000014 RID: 20
		private int y;

		// Token: 0x04000015 RID: 21
		private object isPressed;

		// Token: 0x04000016 RID: 22
		public const int MOUSEEVENTF_MOVE = 1;

		// Token: 0x04000017 RID: 23
		private object ms;
	}
}
