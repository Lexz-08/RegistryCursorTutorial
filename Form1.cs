using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RegistryCursorTutorial
{
	public partial class Form1 : Form
	{
		// determines whether or not the program
		// will use pure code to load the cursor
		// or the referenced dll as a shortcut
		private static bool dll = false;

		[DllImport("user32.dll")]
		private static extern IntPtr LoadCursorFromFile(string CursorFile);

		public Form1()
		{
			InitializeComponent();

			if (dll == true)
			{
				string cursorPath_Link = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Link_Select);
				Cursor cursor_Link = RegistryCursor.LoadFromPath(cursorPath_Link);

				btnLoadCursor.Cursor = cursor_Link;

				string cursorPath_Normal = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Normal_Select);
				lblCursorPath.Text = cursorPath_Normal;

				Bitmap curBitmap = ToBitmap(RegistryCursor.LoadFromPath(cursorPath_Normal));
				picSelectedCursor.Image = curBitmap;
				btnHoverMe.Cursor = RegistryCursor.LoadFromPath(cursorPath_Normal);
			}
			else if (dll == false)
			{
				// open the Registry key containing the string values
				// holding the file paths to the different cursors
				// of the current cursor scheme
				RegistryKey cursorRegKey = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Cursors");

				// get the "Normal" cursor file path
				// get the "Link" cursor file path
				string regKey_NormalCursor = cursorRegKey.GetValue("Arrow").ToString();
				string regKey_LinkCursor = cursorRegKey.GetValue("Hand").ToString();

				// use the native Windows api to get the cursor handle from the given file path
				IntPtr normalCursor_Handle = LoadCursorFromFile(regKey_NormalCursor);
				IntPtr linkCursor_Handle = LoadCursorFromFile(regKey_LinkCursor);

				// load the cursor from the cursor handle
				Cursor normalCursor = new Cursor(normalCursor_Handle);
				Cursor linkCursor = new Cursor(linkCursor_Handle);

				// set the basic starting ui settings
				btnLoadCursor.Cursor = linkCursor;
				btnHoverMe.Cursor = normalCursor;
				lblCursorPath.Text = regKey_NormalCursor;
				Bitmap curNormal_Bitmap = ToBitmap(normalCursor);
				picSelectedCursor.Image = curNormal_Bitmap;
			}
		}

		private void LoadCursor(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog
			{
				Title = "Please select a cursor to load...",
				Filter = "Cursor (All)|*.cur; *.ani|" +
						"Cursor (Static)|*.cur|" +
						"Cursor (Animated)|*.ani",
				FilterIndex = 1,
			})
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					if (dll == true)
					{
						// use the RegistryCursor.LoadFromPath(string) method to get the cursor from the file path
						string cursorPath = ofd.FileName;
						Cursor cursor = RegistryCursor.LoadFromPath(cursorPath);

						// set the "Hover Me" button's cursor to the loaded cursor
						btnHoverMe.Cursor = cursor;

						// display the new cursor in the picture box so the user
						// can see without constantly hovering over the
						// "Hover Me" button
						Bitmap curBitmap = ToBitmap(cursor);
						picSelectedCursor.Image = curBitmap;
					}
					else if (dll == false)
					{
						// use the native Windows api to get the cursor handle from the given file path
						string cursorPath = ofd.FileName;
						IntPtr cursorHandle = LoadCursorFromFile(cursorPath);

						// create the cursor from the cursor handle
						Cursor cursor = new Cursor(cursorHandle);

						// display the file path and cursor image
						Bitmap cursorBitmap = ToBitmap(cursor);
						picSelectedCursor.Image = cursorBitmap;
						lblCursorPath.Text = cursorPath;
						btnHoverMe.Cursor = cursor;
					}
				}
			}
		}

		// simple function to draw a cursor to a bitmap to display it visually
		private Bitmap ToBitmap(Cursor Cursor)
		{
			Bitmap curBitmap = new Bitmap(Cursor.Size.Width, Cursor.Size.Height);

			using (Graphics g = Graphics.FromImage(curBitmap))
			{
				Cursor.Draw(g, new Rectangle(0, 0, curBitmap.Width, curBitmap.Height));
			}

			return curBitmap;
		}
	}
}
