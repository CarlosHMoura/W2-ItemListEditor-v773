﻿using System;
using System.Windows.Forms;

namespace ItemListEditor {
	static class Program {
		[STAThread]
		static void Main ( ) {
			Application.EnableVisualStyles ( );
			Application.SetCompatibleTextRenderingDefault ( false );
			Application.Run ( new W2_ItemListEditor ( ) );
		}
	}
}